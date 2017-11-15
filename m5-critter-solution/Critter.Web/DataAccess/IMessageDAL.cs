using Critter.Web.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critter.Web.DataAccess
{
    public interface IMessageDAL
    {
        List<Message> GetPublicMessages(int numberOfMessagesToLimit);

        /// <summary>
        /// Returns all public messages that came after a certain date.
        /// </summary>
        /// <param name="sinceDate"></param>
        /// <returns></returns>
        List<Message> GetPublicMessages(DateTime sinceDate);

        List<Message> SearchMessagesBySender(string username, DateTime sinceDate);
        List<Message> SearchMessagesByText(string messageText);

        List<Message> GetPrivateMessagesForUser(string username);
        List<Message> GetAllSentMessageForUser(string username);

        bool CreateMessage(Message message);
        Message GetMessage(int messageId);
        void DeleteMessage(int messageId);

        /// <summary>
        /// Gets all conversations that a user is a part of (either sending directly to someone OR receiving from someone)
        /// </summary>        
        List<Conversation> GetConversations(string forUser);

        /// <summary>
        /// Gets all conversastions that a user is a part of (either sending directly to someone OR receiving from someone) after a datetime.
        /// </summary>
        /// <param name="forUser"></param>
        /// <param name="sinceDate"></param>
        /// <returns></returns>
        List<Conversation> GetConversations(string forUser, DateTime sinceDate);

        /// <summary>
        /// Gets a conversation update between two users
        /// </summary>
        /// <param name="forUser"></param>
        /// <param name="withUser"></param>
        /// <param name="sinceDate"></param>
        /// <returns></returns>
        Conversation GetConversations(string forUser, string withUser, DateTime sinceDate);

        /// <summary>
        /// Gets an entire conversation between two users
        /// </summary>
        Conversation GetConversations(string forUser, string withUser);
           
    }
}
