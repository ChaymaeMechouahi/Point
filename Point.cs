using System;
namespace exPoint
{
    public class Program
    {
        public static Main()
        {

        }
    }
    //********La classe Point ********//
    public class Point
    {
        private public int x;   //Le x du point sur le plan (x,y)   
        private public int y;   //Le y du point sur le plan (x,y) 
        public Point(int ex,int ey)//constructeur 
        {
            x = ex;//initialisation d'x
            y = ey;//initialisation d'y
        }
        public int leX  //setters getters d'x
        {
            get { return x; }
            set { x = value; }
        }
        public int leY  //setters getters d'y
        {
            get { return y; }
            set { y = value; }
        }
        public float distance (Point p1, Point p2)//distance entre deux points 
        {
            float d = 0;
            d = Math.Sqrt(((p1.x - p2.x) * (p1.x - p2.x)) + ((p1.y - p2.y) * (p1.y - p2.y)));//relation qui détermine la distance 
            return d;//return la distance 
        }
        public bool egalite (Point p1 , Point p2) //s'assurer que deux point sont =
        {
            return ((p1.x == p2.x) && (p1.y == p2.y));//comparaison de x et y des deux points  
        }
        public void Translation(Point p1, int x1 , int y1)//translation d'un point 
        {
            p1.x = p1.x + x1;//move the x
            p1.y = p1.y + y1;//move the y
        }
        public bool lineaire (Point p1 , Point p2 , Point p3)// La linéarité de 3 points 
        {
            float cd1 = 0;//coefficient directeur 1
            float cd2 = 0;//coefficient directeur 2
            cd1 = (p2.y-p1.y)/(p2.x-p1.x);//calcul
            cd2 = (p3.y-p1.y)/(p3.x-p1.x);//calcul
            return (cd1 == cd2);//return se fera selon la comparaison 
        }
    }
    //********** La Classe Droite ******** //
    public class Droite 
    {
        Point ext1 ;//extrémité 1 de la droite 
        Point ext2;//extrémité 2 de la droite
        public Droite (int x1, int x2, int y1, int y2)//constructeur 
        {
            ext1 = new Point(x1, y1);//initilaisation de premiere extremite : instance de la classe point 
            ext2 = new Point(x2, y2);//initilaisation de deuxieme  extremite : instance de la classe point 
        }
        public Point exT1  //setters getters d'extrémité 1
        {
            get { return ext1; }
            set { ext1 = value; }
        }
        public Point exT2  //setters getters d'extrémité 2
        {
            get { return ext2; }
            set { ext2 = value; }
        }
        public bool egalite ( Droite d1 , Droite d2)//s'assurer que deux droites  sont =
        {
            return ((d1.ext1 == d2.ext1) && (d1.ext2 == d2.ext2));//return la valeur de l'expression if false or true  
        }
        public bool parallele(Droite d1, Droite d2)//s'assurer que deux droites  sont paralléles
        {
            return ; 
        }
        public bool intersection(Droite d1, Droite d2)//s'assurer que deux droites  sont en intersection
        {
            return ((d1.ext1 == d2.ext1) && (d1.ext2 == d2.ext2));  
        }

    }
    //*************La classe circle ********/
    public class Circle
    {
        private Point center;//le centre du cercle 
        private int rayon;//le rayon du cercle 
        public Circle (int x,int y , int r )//constructeur du cercle 
        {
            center = new Point(x,y);//initialisation du center qui est un point "instance de la classe Point"   
            rayon = r;//initialisation rayon 
        }
        public Point Center  //setters getters du center 
        {
            get { return center; }
            set { center = value; }
        }
        public int Rayon   //setters getters du rayon 
        {
            get { return rayon; }
            set { rayon = value; }
        }
    }
    public class Elipsse
    {

    }
}
