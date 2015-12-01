﻿// FFXIVAPP.Plugin.Event
// FFXIVAPP & Related Plugins/Modules
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Windows;

namespace FFXIVAPP.Plugin.Event.Localization
{
    public abstract class Chinese
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("event_", "*PH*");
            Dictionary.Add("event_AddUpdateEventButtonText", "新增或改变事件");
            Dictionary.Add("event_RegExHeader", "RegEx");
            Dictionary.Add("event_RegExLabel", "RegEx:");
            Dictionary.Add("event_SampleText", "侦察兵秃鹫翼刀已经准备好.");
            Dictionary.Add("event_SoundHeader", "音效");
            Dictionary.Add("event_SoundLabel", "音效:");
            Dictionary.Add("event_DelayHeader", "延迟 (秒)");
            Dictionary.Add("event_DelayLabel", "延迟 (秒):");
            Dictionary.Add("event_EnabledHeader", "开启");
            Dictionary.Add("event_CategoryLabel", "类别:");
            Dictionary.Add("event_CategoryHeader", "类别");
            Dictionary.Add("event_MiscellaneousLabel", "杂项");
            Dictionary.Add("event_RefreshSoundListButtonText", "刷新音效列表");
            Dictionary.Add("event_ExecutableLabel", "执行:");
            Dictionary.Add("event_SelectExecutableButtonText", "选择执行模块");
            Dictionary.Add("event_ExecutableHeader", "执行");
            Dictionary.Add("event_VolumeHeader", "音量");
            Dictionary.Add("event_VolumeLabel", "音量:");
            Dictionary.Add("event_TestSoundButtonText", "测试");
            Dictionary.Add("event_GitHubButtonText", "打开项目源代码 (GitHub)");
            Dictionary.Add("event_EventOptionsHeader", "事件选项");
            Dictionary.Add("event_SoundOptionsHeader", "音效选项");
            Dictionary.Add("event_ExecutableOptionsHeader", "执行模块选项");
            Dictionary.Add("event_GlobalVolumeHeader", "全局音量");
            Dictionary.Add("event_TTSHeader", "TTS");
            Dictionary.Add("event_RateHeader", "Rate");
            Dictionary.Add("event_TTSLabel", "TTS");
            Dictionary.Add("event_RateLabel", "Rate");
            Dictionary.Add("event_ArgumentsLabel", "Arguments");
            return Dictionary;
        }
    }
}
