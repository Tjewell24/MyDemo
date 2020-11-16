using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLibrary.BusinessLogic
{
    public static class TicketProcessor
    {
        public static int CreateTicket( int ticketId, string ticketTitle, string ticketDescription, string ticketSubmitter, int ticketPriority, string ticketStatus, DateTime ticketCreatedOn, DateTime ticketUpdatedOn, string ticketComment)
        {
            TicketModel data = new TicketModel
            {
                
                TicketId = ticketId,
                TicketTitle = ticketTitle,
                TicketDescription = ticketDescription,
                TicketSubmitter = ticketSubmitter,
                TicketPriority = ticketPriority,
                TicketStatus = ticketStatus,
                
                TicketComment = ticketComment,
                TicketCreatedOn = ticketCreatedOn,
                TicketUpdatedOn = ticketUpdatedOn,


            };

            string sql = @"insert into dbo.Ticket ( TicketId, TicketTitle, TicketDescription, TicketSubmitter, TicketPriority, TicketStatus,TicketCreatedOn,
              TicketUpdatedOn, TicketComment) values (@TicketId,@TicketTitle,@TicketDescription,@TicketSubmitter,@TicketPriority,@TicketStatus,@TicketCreatedOn,@TicketUpdatedOn,@TicketComment);";
            return SqlDataAccess.SaveData(sql, data);

        }

        public static List<TicketModel> LoadTickets()
        {
            string sql = @"select TicketId,TicketId,TicketTitle,TicketDescription,TicketSubmitter,TicketPriority,TicketStatus,TicketCreatedOn,TicketUpdatedOn,TicketComment from dbo.Ticket;";

            return SqlDataAccess.LoadData<TicketModel>(sql);

        }
    }
}
