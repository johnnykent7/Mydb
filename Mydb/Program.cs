using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mydb
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new MydbEntities();
            video.AddVideo("First Video", DateTime.Now, "Romance");
            video.spAddVideo("second video", DateTime.Today, "Romance");


        }
    }
}
