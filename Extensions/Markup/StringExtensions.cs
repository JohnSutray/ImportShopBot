﻿using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace BotShop.Extensions.Markup {
  public static class StringExtensions {
    public static KeyboardButton ToKeyboardButton(this string value) => new KeyboardButton(value);

    public static InputOnlineFile ToInputMedia(this string value) => new InputOnlineFile(value);
  }
}
