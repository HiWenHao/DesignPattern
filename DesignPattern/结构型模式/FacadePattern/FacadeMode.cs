using System;

namespace DesignPattern.FacadePattern
{
    /// <summary>
    /// 对外窗口
    /// </summary>
    public class FacadeMode
    {
        private Window m_window;
        private Wifi m_wifi;
        private Alarm m_alarm;

        /// <summary>
        /// 对外窗口
        /// </summary>
        public FacadeMode()
        {
            m_window = new Window();
            m_wifi = new Wifi();
            m_alarm = new Alarm();
        }

        /// <summary>
        /// 到家
        /// </summary>
        public void BackHome()
        {
            Console.WriteLine("Xiaohei is back.");
            m_window.Open();
            m_wifi.Open();
            m_alarm.Close();
        }

        /// <summary>
        /// 该睡觉
        /// </summary>
        public void GoSleep()
        {
            Console.WriteLine("Should be sleep.");
            m_window.Close();
            m_wifi.Close();
            m_alarm.Open();
        }

        /// <summary>
        /// 去工作
        /// </summary>
        public void GoWork()
        {
            Console.WriteLine("Wow,go to work.");
            m_window.Close();
            m_wifi.Close();
            m_alarm.Close();
        }
    }
}
