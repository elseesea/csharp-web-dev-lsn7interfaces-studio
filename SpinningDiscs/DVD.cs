using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // DVD is different from CDs in that it has to
        // 1. Burn layers
        // 2. Burn movie format

        // General behavior from textbook
        /*          1. They both spin INTERFACE
                    2. They both store data ABSTRACT - DEPENDS ON WHAT'S BEING STORED
                    3. Data gets written to the discs by using a laser ABSTRACT - DEPENDS ON LAYERS
                    4. The data on the discs can be read by using a laser ABSTRACT - DEPENDS ON LAYERS
                    5. Once loaded, they both report information like name, capacity, contents, and disc type. INTERFACE

                  Properties
                    1. Capacity CONSTANT
                    2. Name / Title
                    3. Contents
                    4. Disc type CONSTANT
        */

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        private const string SPINRATE = "570 - 1600";
        private const string DISCTYPE = "DVD";
        private const double CAPACITY = 4700; // in megabytes
        public string MovieTitle { get; set; }

        public DVD () : base()
        {

        }

        public DVD (string movieTitle) : base()
        {
            MovieTitle = movieTitle;
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of " + SPINRATE + " rpm.");
        }

        public override void ReportDiscInfo()
        {
            Console.WriteLine("This " + DISCTYPE + " has " + CAPACITY + " MB capacity.");
            Console.WriteLine("The movie title is " + MovieTitle + ".");
        }

        public override void WriteUsingLaser()
        {
            Console.WriteLine("using laser to write to multiple layers.");
        }

        public void StoreData()
        {
            Console.WriteLine("Writing to DVD ...");
            WriteUsingLaser();
        }
    } // class
} // namespace

