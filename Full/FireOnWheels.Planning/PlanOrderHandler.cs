using FireOnWheels.Messages;
using NServiceBus;

namespace FireOnWheels.Planning
{
    public class PlanOrderHandler: IHandleMessages<PlanOrderCommand>
    {
        private readonly IBus bus;

        public PlanOrderHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(PlanOrderCommand message)
        {
            //Do planning
            System.Console.WriteLine("----------------->Order is planned! To address: {0}", message.AddressTo);
            bus.Reply<IOrderPlannedMessage>(msg => { });
        }
    }
}
