using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BallApp {
    internal class TennisBall : Obj{
        Random rand = new Random(); //乱数インスタンス

        public static int Count { get; set; }

        public TennisBall(double xp, double yp)
            : base(xp, yp, @"Picture\tennis_ball.png") {

            MoveX = rand.Next(-25, 50);
            MoveY = rand.Next(-25, 50);

            Count++;
        }

        public override bool Move() {
            if (PosX > 750 || PosX < 0) {
                //移動量の符号を反転
                MoveX = -MoveX;
            }

            if (PosY > 500 || PosY < 0) {
                //移動量の符号を反転
                MoveY = -MoveY;
            }

            PosX += MoveX;
            PosY += MoveY;

            return true;



        }
    }
}
