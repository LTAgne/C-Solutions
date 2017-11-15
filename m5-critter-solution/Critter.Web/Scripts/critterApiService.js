function critterApiService() {

    this.serviceUrl = "http://" + window.location.host + "/";


    this.fetchNewMessages = function (sinceDateValue, successCallback, failCallback) {
        $.ajax({
            url: this.serviceUrl + "api/messages",
            type: "GET",
            data: {
                sinceDate: sinceDateValue
            },
            dataType: "json"
        }).success(successCallback)
            .fail(function (xhr, statusCode, statusMessage) {
                console.log(xhr);
                console.log(statusCode);
                console.log(statusMessage);
            });
    }


    this.fetchNewConversations = function (forUser, sinceDateValue, successCallback) {
        $.ajax({
            url: this.serviceUrl +  "api/" + forUser + "/conversations",
            type: "GET",
            data: {
                sinceDate: sinceDateValue
            },
            dataType: "json"
        }).success(successCallback)
            .fail(function (xhr, statusCode, statusMessage) {
                console.log(xhr);
                console.log(statusCode);
                console.log(statusMessage);
            });
    }

    this.getNewThreads = function (forUser, withUser, sinceDateValue, successCallback) {
        $.ajax({
            url: this.serviceUrl + "api/" + forUser + "/conversations/" + withUser,
            type: "GET",
            data: {
                sinceDate: sinceDateValue
            },
            dataType: "json"
        }).success(successCallback)
           .fail(function (xhr, statusCode, statusMessage) {
               console.log(xhr);
               console.log(statusCode);
               console.log(statusMessage);
           });
    }
}