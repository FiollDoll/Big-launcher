using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Buttons
{
	public class ButtonsInScene
	{
		[XmlArray("Collection"), XmlArrayItem("Item")]
		public List<ButtonInfo> buttons { get; set;}

		public ButtonsInScene()
        {

        }
	}

	public class ButtonInfo
	{
		public string name;
		public string command;
		public string action;
		public ButtonLocation position = new ButtonLocation();

		public ButtonInfo()
        {

        }

		public ButtonInfo(string nameButton, string commandButton, string textButton, int x, int y)
		{
			name = nameButton;
			command = commandButton;
			action = textButton;
			position.x = x;
			position.y = y;
		}
	}

	public class ButtonLocation
	{
		public int x, y;
	}
}

