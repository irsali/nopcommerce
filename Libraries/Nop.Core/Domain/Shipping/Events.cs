namespace Nop.Core.Domain.Shipping
{
    /// <summary>
    /// Shipment sent event
    /// </summary>
    public class ShipmentSentEvent
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="shipment">Shipment</param>
        public ShipmentSentEvent(Shipment shipment)
        {
            this.Shipment = shipment;
        }

        /// <summary>
        /// Shipment
        /// </summary>
        public Shipment Shipment { get; }
    }

    /// <summary>
    /// Shipment delivered event
    /// </summary>
    public class ShipmentDeliveredEvent
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="shipment">Shipment</param>
        public ShipmentDeliveredEvent(Shipment shipment)
        {
            this.Shipment = shipment;
        }

        /// <summary>
        /// Shipment
        /// </summary>
        public Shipment Shipment { get; }
    }
}