namespace DesignPattern.AbstractFactoryPattern
{
    public interface IProductAbstractFactory
    {
        IPhoneProduct iphoneProduct();
        IRouterProduct routerProduct();
    }

    public class HuaweiFactory : IProductAbstractFactory
    {
        public IPhoneProduct iphoneProduct()
        {
            return new HuaweiPhone();
        }

        public IRouterProduct routerProduct()
        {
            return new HuaweiRouter();
        }
    }

    public class XiaomiFactory : IProductAbstractFactory
    {
        public IPhoneProduct iphoneProduct()
        {
            return new XiaomiPhone();
        }

        public IRouterProduct routerProduct()
        {
            return new XiaomiRouter();
        }
    }
}
