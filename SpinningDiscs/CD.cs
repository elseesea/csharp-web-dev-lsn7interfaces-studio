using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

        private const string SPINRATE = "200 - 500";
        private const string DISCTYPE = "CD";
        private const double CAPACITY = 680; // in megabytes
        public string ArtistName { get; set; }

        public CD () : base()
        {

        }

        public CD (string artistName) : base()
        {
            ArtistName = artistName;
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of " + SPINRATE + " rpm.");
        }

        public override void ReportDiscInfo()
        {
            Console.WriteLine("This " + DISCTYPE + " has " + CAPACITY + " MB capacity.");
            Console.WriteLine("This artist is " + ArtistName + ".");
        }

        public override void WriteUsingLaser()
        {
            Console.WriteLine("using laser to write to CD");
        }

        public void StoreData()
        {
            Console.WriteLine("Writing to CD ...");
            WriteUsingLaser();
        }
    }
}
