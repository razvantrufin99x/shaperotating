using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace shaperotating 
{
    public class shapedpiesa
    {
        public Form1 f;
        public string valoare = "full"; //tipul de piesa
        public int dimensiuneX = 4;
        public int dimensiuneY = 4;
        public int pozitiaX = 20;
        public int pozitiaY = 20;


        
        public int[,] patrate =  {
                                      {1,1,1,1},
                                      {1,1,1,1},
                                      {1,1,1,1},
                                      {1,1,1,1}
                                   };

        public int[,] full =  {
                                      {1,1,1,1},
                                      {1,1,1,1},
                                      {1,1,1,1},
                                      {1,1,1,1}
                                   };



        public int[,] patratmicshapeTL = {
                                      {1,1,1,1},
                                      {1,1,1,1},
                                      {1,1,1,1},
                                      {1,1,1,1}
                                   };
        public int[,] patratmicshapeTR = {
                                      {0,0,0,1},
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                   };
        public int[,] patratmicshapeBL = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {1,0,0,0}
                                   };
        public int[,] patratmicshapeBR = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,1}
                                   };








        public int[,] patratmareshapeTL = {
                                      {1,1,0,0},
                                      {1,1,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                   };
        public int[,] patratmareshapeTR = {
                                      {0,0,1,1},
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                   };
        public int[,] patratmareshapeBL = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {1,1,0,0},
                                      {1,1,0,0}
                                   };
        public int[,] patratmareshapeBR = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,1,1},
                                      {0,0,1,1}
                                   };
        public int[,] patratmareshapeC = {
                                      {0,0,0,0},
                                      {0,1,1,0},
                                      {0,1,1,0},
                                      {0,0,0,0}
                                   };









        public int[,] lshapeRTL = {
                                      {1,1,1,1},
                                      {1,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                   };
        public int[,] lshapeRTR = {
                                      {0,0,1,1},
                                      {0,0,0,1},
                                      {0,0,0,1},
                                      {0,0,0,1}
                                   };
        public int[,] lshapeRBR = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,1},
                                      {1,1,1,1}
                                   };
        public int[,] lshapeRBL = {
                                      {1,0,0,0},
                                      {1,0,0,0},
                                      {1,0,0,0},
                                      {1,1,0,0}
                                   };









        public int[,] lshapeLTL = {
                                      {1,1,1,1},
                                      {0,0,0,1},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                   };
        public int[,] lshapeLTR = {
                                      {0,0,0,1},
                                      {0,0,0,1},
                                      {0,0,0,1},
                                      {0,0,1,1}
                                   };
        public int[,] lshapeLBL = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {1,0,0,0},
                                      {1,1,1,1}
                                   };
        public int[,] lshapeLBR = {
                                      {1,1,0,0},
                                      {1,0,0,0},
                                      {1,0,0,0},
                                      {1,0,0,0}
                                   };









        public int[,] barashapeL = {
                                      {1,0,0,0},
                                      {1,0,0,0},
                                      {1,0,0,0},
                                      {1,0,0,0}
                                   };
        public int[,] barashapeT = {
                                      {1,1,1,1},
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                   };
        public int[,] barashapeR = {
                                      {0,0,0,1},
                                      {0,0,0,1},
                                      {0,0,0,1},
                                      {0,0,0,1}
                                   };
        public int[,] barashapeB = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {1,1,1,1}
                                   };






        public int[,] sshapeLTL = {
                                      {0,1,1,0},
                                      {1,1,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                   };
        public int[,] sshapeLTR = {
                                      {0,0,1,0},
                                      {0,0,1,1},
                                      {0,0,0,1},
                                      {0,0,0,0}
                                   };
        public int[,] sshapeLBR = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,1,1},
                                      {0,1,1,0}
                                   };
        public int[,] sshapeLBL = {
                                      {0,0,0,0},
                                      {1,0,0,0},
                                      {1,1,0,0},
                                      {0,1,0,0}
                                   };





        public int[,] sshapeRTL = {
                                      {1,1,0,0},
                                      {0,1,1,0},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                   };
        public int[,] sshapeRTR = {
                                      {0,0,0,1},
                                      {0,0,1,1},
                                      {0,0,1,0},
                                      {0,0,0,0}
                                   };
        public int[,] sshapeRBL = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,1,1,0},
                                      {0,0,1,1}
                                   };
        public int[,] sshapeRBT = {
                                      {0,0,0,0},
                                      {0,1,0,0},
                                      {1,1,0,0},
                                      {1,0,0,0}
                                   };






        public int[,] blanckshape = {
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0},
                                      {0,0,0,0}
                                     };

        public int[,] fillshape = {
                                      {1,1,1,1},
                                      {1,1,1,1},
                                      {1,1,1,1},
                                      {1,1,1,1}
                                     };



        /*
         
patratmicshapeTL
patratmicshapeTR
patratmicshapeBL
patratmicshapeBR
         * 
patratmareshapeTL
patratmareshapeTR
patratmareshapeBL
patratmareshapeBR
patratmareshapeC
         * 
lshapeRTL
lshapeRTR
lshapeRBR
lshapeRBL
         * 
lshapeLTL
lshapeLTR
lshapeLBL
lshapeLBR
         * 
barashapeL
barashapeT
barashapeR
barashapeB
         * 
sshapeLTL
sshapeLTR
sshapeLBR
sshapeLBL
         * 
sshapeRTL
sshapeRTR
sshapeRBL
sshapeRBT
         * 
blanckshape
fillshape
         * 
         
         */



        public shapedpiesa() {
                  
        }
        public shapedpiesa(string v) {
            valoare = v;
        }
        public void loadValuesIntoPatrate()
        {
            patrate[0, 0] = 1;
            patrate[0, 1] = 1;
            patrate[0, 2] = 1;
            patrate[0, 3] = 1;

            patrate[1, 0] = 1;
            patrate[1, 1] = 1;
            patrate[1, 2] = 1;
            patrate[1, 3] = 1;

            patrate[2, 0] = 1;
            patrate[2, 1] = 1;
            patrate[2, 2] = 1;
            patrate[2, 3] = 1;

            patrate[3, 0] = 1;
            patrate[3, 1] = 1;
            patrate[3, 2] = 1;
            patrate[3, 3] = 1;

        }

       

       


        public void drawTheShape(ref Graphics gg)
        {gg.Clear(Color.White);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                    
                    if (patrate[i, j] == 0)
                    {
                        gg.DrawRectangle(new Pen(Color.Red), 20 + i * 22, 20 + j * 22, 20, 20);
                    }
                    else if (patrate[i, j] == 1)
                    {
                        gg.FillRectangle(new SolidBrush(Color.Red), 20 + i * 22, 20 + j * 22, 20, 20);
                    }
                   
                }
            
            }
            
        }


        public void fill(ref int [,] a)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    patrate =  a;
                   

                }

            }

        }


    }
}
