namespace DesignPattern.BridgePattern
{
    /// <summary>
    /// 品牌接口
    /// </summary>
    public interface BridgeBrand
    {
        /// <summary>
        /// 具体的品牌信息
        /// </summary>
        string BrandInfo { get; }
    }

    public class Lenovo : BridgeBrand
    {
        public string BrandInfo => "联想";
    }
    public class Apple : BridgeBrand
    {
        public string BrandInfo => "苹果";
    }
    public class Huawei : BridgeBrand
    {
        public string BrandInfo => "华为";
    }
}
