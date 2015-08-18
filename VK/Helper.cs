/*
 * Пример к статье: Разработка desktop-приложения для «ВКонтакте» на C#
 * Автор: Алексей Немиро
 * http://aleksey.nemiro.ru
 * http://foxtools.ru
 * http://kbyte.ru
 * 24.07.2011
 * 
 * По всем вопросам обращайтесь на форум:
 * http://kbyte.ru/ru/Forums?id=0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace VK
{
  static class Helper
  {
    /// <summary>
    /// Хелпер-функция, возвращающая данные из XmlNode в зависимости от их наличия
    /// </summary>
    /// <param name="input">XmlNode</param>
    public static string GetDataFromXmlNode(XmlNode input)
    {
      if (input == null || String.IsNullOrEmpty(input.InnerText))
      {
        return "нет данных";
      }
      else
      {
        return input.InnerText;
      }
    }
    /// <summary>
    /// Хелпер-функция, возвращающая данные из XmlNode в виде целого числа типа Int, в зависимости от их наличия
    /// </summary>
    /// <param name="input">XmlNode</param>
    public static int GetDataFromXmlNodeAsInt(XmlNode input)
    {
      if (input == null || String.IsNullOrEmpty(input.InnerText))
      {
        return 0;
      }
      else
      {
        return Convert.ToInt32(input.InnerText);
      }
    }
  }
}
