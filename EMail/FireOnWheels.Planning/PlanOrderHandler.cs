using FireOnWheels.Messages;
using NServiceBus;

namespace FireOnWheels.Email
{
    public class PlanOrderHandler: IHandleMessages<EmailCommand>
    {
        private readonly IBus bus;

        public PlanOrderHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(EmailCommand message)
        {
            //Do planning
            System.Console.WriteLine("----------------->Order email was sent");
            bus.Reply<IEmailSentMessage>(msg => { });
        }
    }
}
