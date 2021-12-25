using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelOrganizer
{
    /// <summary>
    /// The Organizer Of Cars.
    /// </summary>
    public class CarModelOrganizer : IEquatable<CarModelOrganizer>
    {
        /// <summary>
        /// The Number Of Models.
        /// </summary>
        public int count = 0;

        /// <summary>
        /// Company's Name.
        /// </summary>
        public string Company { get; set; }    
        
        /// <summary>
        /// Model's Name.
        /// </summary>
        public string Model { get; set; }
        
        /// <summary>
        /// Price's Number.
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// The Output Appearance.
        /// </summary>
        /// <returns> Company: NumberOfModels [Models]</returns>
        public override string ToString()
        {
            return Company + ": " + count + " [" + Model + "]";
        }

        /// <summary>
        /// ?
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Equals(CarModelOrganizer? other)
        {
            throw new NotImplementedException();
        }



    }
}