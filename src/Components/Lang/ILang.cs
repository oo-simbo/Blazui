﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.Component.Lang
{
    public interface ILang
    {
        /// <summary>
        /// 初始化加载的json文件
        /// </summary>
        void InitBLangBase();

        /// <summary>
        /// 读取对应文件的语言
        /// </summary>
        /// <param name="sections">节点</param>
        /// <returns></returns>
        string T(string sections);
    }
}
