using System.Collections.Generic;

namespace Idfy.Signature
{
    public class AddonsSignerRequest
    {
        /// <summary>
        /// A list of the addons you want to order. Additional cost will incur.
        /// </summary>
        public List<AddonSignerType> Types { get; set; }
    }
}