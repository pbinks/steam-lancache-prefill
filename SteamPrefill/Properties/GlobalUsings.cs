﻿global using AutoMapper;
global using ByteSizeLib;
global using CliFx;
global using CliFx.Attributes;
global using CliFx.Exceptions;
global using CliFx.Extensibility;
global using CliFx.Infrastructure;
global using Cysharp.Text;
global using HexMate;
global using JetBrains.Annotations;
global using LancachePrefill.Common;
global using LancachePrefill.Common.Exceptions;
global using LancachePrefill.Common.Extensions;
global using NStack;
global using ProtoBuf;
global using Spectre.Console;
global using SteamKit2;
global using SteamKit2.CDN;
global using SteamKit2.Internal;
global using SteamPrefill.CliCommands.Benchmark;
global using SteamPrefill.Handlers;
global using SteamPrefill.Handlers.Steam;
global using SteamPrefill.Models;
global using SteamPrefill.Models.Enums;
global using SteamPrefill.Models.Exceptions;
global using SteamPrefill.Settings;
global using SteamPrefill.Tui;
global using SteamPrefill.Utils;
global using System;
global using System.Collections;
global using System.Collections.Concurrent;
global using System.Collections.Generic;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.IO;
global using System.Linq;
global using System.Net.Http;
global using System.Runtime.InteropServices;
global using System.Runtime.Serialization;
global using System.Security.Cryptography;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Threading.Tasks;
global using Terminal.Gui;
global using Terminal.Gui.Graphs;
global using Wcwidth;
global using static LancachePrefill.Common.SpectreFormatters;
global using AnsiConsoleExtensions = LancachePrefill.Common.Extensions.AnsiConsoleExtensions;
global using PicsProductInfo = SteamKit2.SteamApps.PICSProductInfoCallback.PICSProductInfo;
global using Architecture = SteamPrefill.Models.Enums.Architecture;
global using OperatingSystem = SteamPrefill.Models.Enums.OperatingSystem;
global using static SteamKit2.SteamApps;
global using System.Security.Authentication;