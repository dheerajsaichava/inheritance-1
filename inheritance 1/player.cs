using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_1
{
    class player:person
    {
        int points;

        player(int pts)

        {

            String FullName = FirstName + LastName;

            pts = points;

            Console.WriteLine("Employee " + FullName + " points are " + pts.ToString());

        }

        player()

        {

            String FullName = FirstName + LastName;

            points = 846;

            Console.WriteLine("player" + FullName + "points are" + points);

        }

    }



}
       
    

