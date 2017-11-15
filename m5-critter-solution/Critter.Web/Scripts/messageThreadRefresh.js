/// <reference path="critterApiService.js" />
/// <reference path="jquery-2.2.2.js" />



// Get the date from the most recent message
// and use the critterApiService to fetch any new messages
function refreshMessageFeed() {
    var lastMessage = $(".message-list").children().first();

    if (lastMessage != null) {
        var lastMessageDateTime = lastMessage.children("time").attr("datetime");
        var service = new critterApiService();
        service.fetchNewMessages(lastMessageDateTime, addNewMessagesToTable);
    }
}

// Get updated conversation threads
function refreshConversationFeed() {
    var lastMessage = $(".message-list").children().first();
    var forUser = window.location.pathname.split('/')[2];

    if (lastMessage != null && forUser != null) {
        var lastMessageDateTime = lastMessage.children("time").attr("datetime");
        var service = new critterApiService();
        service.fetchNewConversations(forUser, lastMessageDateTime, updateConversationThreads);
    }
}


function refreshActiveThread() {
    var lastMessage = $(".message-list").children().first();
    var forUser = window.location.pathname.split('/')[2];
    var withUser = window.location.pathname.split('/')[4];

    if (lastMessage != null && forUser != null && withUser != null) {
        var lastMessageDateTime = lastMessage.children("time").attr("datetime");
        var service = new critterApiService();
        service.getNewThreads(forUser, withUser, lastMessageDateTime, updateThreadMessages);
    }
}

function updateThreadMessages(jsonData) {
    
    if (jsonData.Messages.length == 0) {
        return;
    }

    var list = $(".message-list");

    for (var i = 0; i < jsonData.Messages.length; i++) {
        var message = jsonData.Messages[i];
        var date = getFromJsonDateDate(message.CreatedDate);
        var messageTypeClass = (message.Sender.toLowerCase() == jsonData.ForUser.toLowerCase()) ? "from" : "to";
        
        var threadedMessage = createThreadedMessageObject(message.Sender, message.MessageText, date);
        threadedMessage.addClass(messageTypeClass);

        // For the push down effect, hide-first, add second, then slideDown
        threadedMessage.hide();
        list.prepend(threadedMessage);
        threadedMessage.slideDown();
    }

    $("time.timeago").timeago();
}

function updateConversationThreads(jsonData) {
    var currentUser = window.location.pathname.split('/')[2];

    if (jsonData.length == 0) {
        return;
    }

    var list = $(".message-list");

    for (var i = 0; i < jsonData.length; i++) {
        var currentConversation = $(`#conversation_${jsonData[i].WithUser}`);

        // Hide the current conversation
        if (currentConversation != null) {
            currentConversation.remove();
        }

        // Add a new conversation     
        var date = getFromJsonDateDate(jsonData[i].Messages[0].CreatedDate);
        var message = createNewMessageObject(jsonData[i].WithUser, jsonData[i].Messages[0].MessageText, date, `users/${currentUser}/conversations/${jsonData[i].WithUser}`);

        message.attr("id", `conversation_${jsonData[i].WithUser}`);
        message.hide();
        list.prepend(message);
        message.slideDown();
    }

    $("time.timeago").timeago();

}

function addNewMessagesToTable(jsonData) {

    if (jsonData.length == 0) {
        return;
    }

    var list = $(".message-list");

    for (var i = 0; i < jsonData.length; i++) {
        var date = getFromJsonDateDate(jsonData[i].CreatedDate);
        var message = createNewMessageObject(jsonData[i].Sender, jsonData[i].MessageText, date, `messages?userName=${jsonData[i].Sender}`);

        // For the push down effect, hide-first, add second, then slideDown
        message.hide();
        list.prepend(message);
        message.slideDown();
    }

    $("time.timeago").timeago();
}

function createNewMessageObject(sender, text, sentDate, linkUrl) {
    var sentDateString = sentDate.toISOString();

    var message = $("<li>").addClass("message");
    var userName = $("<span>").addClass("username");
    var userLink = $("<a>").html(sender)
        .attr("href", linkUrl);
    var messageText = $("<span>").addClass("message-text").html(text);
    var messageTime = $("<time>").addClass("timeago timestamp").text(sentDateString).attr("datetime", sentDateString);

    userName.append(userLink);
    message.append(userName);
    message.append(messageText);
    message.append(messageTime);

    return message;
}

function createThreadedMessageObject(sender, text, sentDate) {
    var sentDateString = sentDate.toISOString();

    var message = $("<li>").addClass("message");
    var userName = $("<span>").addClass("username").html(sender);
    var messageText = $("<span>").addClass("message-text").html(text);
    var messageTime = $("<time>").addClass("timeago timestamp").text(sentDateString).attr("datetime", sentDateString);

    message.append(userName);
    message.append(messageText);
    message.append(messageTime);

    return message;
}

function getFromJsonDateDate(jsonDate) {
    return new Date(parseInt(jsonDate.substr(6)));
}
