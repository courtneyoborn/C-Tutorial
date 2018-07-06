using System;
using System.Collections.Generic;

namespace UdemyTutorial
{

        public class Circle : Shape

        {
       public override void Draw()
       {
          base.Draw();
      }

        }
      public class Shape
       {
          public int Width { get; set; }
          public int Height { get; set; }
          // public Position Position { get; set; }
         //  public ShapeType Type { get; set; }

           public virtual void Draw()
          {

           }
      }
 }
