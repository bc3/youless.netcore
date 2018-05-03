using System;
namespace youless.netcore
{
    public class Status
    {
        /// <summary>
        /// counter in kWh
        /// </summary>
        /// <value>The count.</value>
        public string cnt { get; set; }

        /// <summary>
        /// Pwer consumption in Watt
        /// </summary>
        /// <value>The pwr.</value>
        public int pwr { get; set; }

        /// <summary>
        /// moving average level (intensity of reflected light on analog meters)
        /// </summary>
        /// <value>The lvl.</value>
        public int lvl { get; set; }

        /// <summary>
        /// deviation of reflection
        /// </summary>
        /// <value>The dev.</value>
        public string dev { get; set; }

        /// <summary>
        /// ???
        /// </summary>
        /// <value>The det.</value>
        public string det { get; set; }

        /// <summary>
        /// connection status
        /// </summary>
        /// <value>The con.</value>
        public string con { get; set; }

        /// <summary>
        /// Time until next status update with online monitoring
        /// </summary>
        /// <value>The sts.</value>
        public string sts { get; set; }

        /// <summary>
        /// ???
        /// </summary>
        /// <value>The cs0.</value>
        public string cs0 { get; set; }

        /// <summary>
        /// ps0
        /// </summary>
        /// <value>The ps0.</value>
        public int ps0 { get; set; }

        /// <summary>
        /// aw 10-bit light reflection level (without averaging)
        /// </summary>
        /// <value>The raw.</value>
        public int raw { get; set; }
    }
}
