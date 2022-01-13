using System;

namespace CarModelOrganizer
{
    /// <summary>
    /// The Organizer Of Cars.
    /// </summary>
    public class CarModel : IEquatable<CarModel>
    {
        /// <summary>
        /// The company name.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// The model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The Output Appearance.
        /// </summary>
        /// <returns>Model</returns>
        public override string ToString() => Model;

        /// <summary>
        /// Default constructor
        /// </summary>
        public CarModel() : base()
        {

        }

        /// <summary>
        /// ?
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(CarModel other)
        {
            if (other == null)
                return false;

            return CompanyName == other.CompanyName && Model == other.Model && Price == other.Price;
        }
    }
}