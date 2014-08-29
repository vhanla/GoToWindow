﻿using System;
using GoToWindow.Plugins.ExpandBrowsersTabs.Contracts;
using GoToWindow.Plugins.ExpandBrowsersTabs.Common;

namespace GoToWindow.Plugins.ExpandBrowsersTabs.Chrome
{
	public class ChromeTab : ShortcutBasedTab, ITab
	{
		public ChromeTab(string title, int tabIndex)
			: base(title, tabIndex)
		{
		}
	}
}
