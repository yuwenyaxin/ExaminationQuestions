namespace Questions2.Models
{
    public class BridgeTable
    {
        /// <summary>
        /// Id号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 桥梁类型 0-特大桥 1-大桥 2-中桥 3-框架桥
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
}
