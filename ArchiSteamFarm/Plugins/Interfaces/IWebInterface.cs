//     _                _      _  ____   _                           _____
//    / \    _ __  ___ | |__  (_)/ ___| | |_  ___   __ _  _ __ ___  |  ___|__ _  _ __  _ __ ___
//   / _ \  | '__|/ __|| '_ \ | |\___ \ | __|/ _ \ / _` || '_ ` _ \ | |_  / _` || '__|| '_ ` _ \
//  / ___ \ | |  | (__ | | | || | ___) || |_|  __/| (_| || | | | | ||  _|| (_| || |   | | | | | |
// /_/   \_\|_|   \___||_| |_||_||____/  \__|\___| \__,_||_| |_| |_||_|   \__,_||_|   |_| |_| |_|
// |
// Copyright 2015-2023 Łukasz "JustArchi" Domeradzki
// Contact: JustArchi@JustArchi.net
// |
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// |
// http://www.apache.org/licenses/LICENSE-2.0
// |
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Newtonsoft.Json;

namespace ArchiSteamFarm.Plugins.Interfaces;

public interface IWebInterface : IPlugin {
	/// <summary>
	///     Specifies physical path to static WWW files provided by the plugin. Can be either relative to plugin's assembly location, or absolute. If you don't know better, we recommend value of "www", which assumes that you ship "www" directory together with your plugin's main DLL assembly, similar to ASF.
	/// </summary>
	string PhysicalPath { get; }

	/// <summary>
	///     Specifies web path (address) under which ASF should host your static WWW files in <see cref="PhysicalPath" /> directory. If you don't know better, we recommend value of "/", which allows you to override default ASF files and gives you full flexibility in your <see cref="PhysicalPath" /> directory. However, you can instead host your files under some other fixed location specified here, such as "/MyPlugin".
	/// </summary>
	[JsonProperty]
	string WebPath { get; }
}
