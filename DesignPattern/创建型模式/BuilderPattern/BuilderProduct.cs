using System;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 构建产品
    /// </summary>
    public class BuilderProduct
    {
        private string builderA = "--Product - A";
        private string builderB = "--Product - B";
        private string builderC = "--Product - C";
        private string builderD = "--Product - D";

        public string GetBuildA(string build) { return builderA; }
        public void SetBuildA(string build) { builderA = build; }
        public string GetBuildB(string build) { return builderB; }
        public void SetBuildB(string build) { builderB = build; }
        public string GetBuildC(string build) { return builderC; }
        public void SetBuildC(string build) { builderC = build; }
        public string GetBuildD(string build) { return builderD; }
        public void SetBuildD(string build) { builderD = build; }

        /// <summary>
        /// 打印产品
        /// </summary>
        public void BuilderProductToString()
        {
            Console.WriteLine($"builder - A = {builderA}");
            Console.WriteLine($"builder - B = {builderB}");
            Console.WriteLine($"builder - C = {builderC}");
            Console.WriteLine($"builder - D = {builderD}");
        }
    }
}
