# ExaminationQuestions
一、现有以点集合（按顺序排列）表示的平面多边形，判断这个多边形是否为凸多边形，如果为凸多边形并求面积。注：凸多边形，就是把一个多边形任意一边向两方无限延长成为一条直线，如果多边形的其他各边均在此直线的同旁，那么这个多边形就叫做凸多边形，凸多边形的特性：一是所有内角小于等于180度，二是任意两个顶点间的线段位于多边形的内部或边上。可用C#、C++、Java语言完成。

【解题思路】
1、定义平面点:
public class Point2D{
public double X;
public double Y;
}
2、定义任意多边形，并写方法判断是否为凸多边形，是则算面积：
public class Polygn
{
public List<Point2D> Points;  //按顺序排序的点集合
public Polygn(List<Point2D> points)
{
Points= points;
}

//判断是否为凸多边形方法
public bool IsConvexPolygon()
{
}

//求解凸多边形面积
public double Area()
{
}
}

二、现有一个模型对象——桥表，如下所示，采用C# ASP.net Core编制webAPI实现桥表数据的增、删、改、查，可通过浏览器或者postman访问。要求：采用EFCore技术实现模型与数据库自动映射，采用MVC模式，数据库可采用MySQL、SQLSever等。
///模型——桥表类
public class BridgeTable   
 {
        /// <summary>
        /// Id号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 桥梁类型 0-特大桥  1-大桥 2-中桥 3-框架桥
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 桥名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 起点里程冠号
        /// </summary>
        public string StartMileageNumber { get; set; }
        /// <summary>
        /// 起点里程
        /// </summary>
        public double StartMileage { get; set; }
        /// <summary>
        /// 终点里程冠号
        /// </summary>
        public string EndMileageNumber { get; set; }
        /// <summary>
        /// 终点里程
        /// </summary>
        public double EndMileage { get; set; }

        /// <summary>
        /// 中心里程冠号
        /// </summary>
        public string MidMileageNumber { get; set; }
        /// <summary>
        /// 中心里程
        /// </summary>
        public double MidMileage { get; set; }
        /// <summary>
        /// 孔跨组合
        /// </summary>
        public string SpanCombination { get; set; }
        /// <summary>
        /// 桥梁全长
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// 标准桥面宽
        /// </summary>
        public double GirderWidth { get; set; }
        /// <summary>
        /// 线路条数 单线、双线、三线
        /// </summary>
        public int Line { get; set; }
        /// <summary>
        /// 用途 1交通、2排洪、3交通兼排洪、4其他
        /// </summary>
        public int Use { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Notes { get; set; }
    }

三、三个线程，依次打印“ A“、”B“、C”、。。。。。“ A“、”B“、C”，主进程控制打印次序”开始打印”、各个线程打印、”结束打印“，其中ABC依次按照顺序打印30次，同时随时可以线程取消。
示例输出：
打印开始
A
B
C
..
A
B
C
结束打印
