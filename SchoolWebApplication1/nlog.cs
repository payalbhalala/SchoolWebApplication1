2021-07-01 15:31:48.5897 Debug ScanAssembly('NLog, Version=4.0.0.0, Culture=neutral, PublicKeyToken=5120e14c03d0593c')
2021-07-01 15:31:54.0163 Debug Found assembly location directory: 'C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1\bin\Debug\netcoreapp3.1' (NLog, Version=4.0.0.0, Culture=neutral, PublicKeyToken=5120e14c03d0593c)
2021-07-01 15:31:54.0163 Debug Auto loading based on NLog-Assembly found location: C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1\bin\Debug\netcoreapp3.1
2021-07-01 15:31:54.0206 Debug Search for auto loading files in location: C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1\bin\Debug\netcoreapp3.1
2021-07-01 15:31:54.0206 Debug Found assembly location directory: 'C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1\bin\Debug\netcoreapp3.1' (SchoolWebApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)
2021-07-01 15:31:54.0206 Debug Auto loading based on GetEntryAssembly-Assembly found location: C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1\bin\Debug\netcoreapp3.1
2021-07-01 15:31:54.0365 Debug Auto loading based on AppDomain-BaseDirectory found location: C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1\bin\Debug\netcoreapp3.1
2021-07-01 15:31:54.0365 Debug Start auto loading, location: C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1\bin\Debug\netcoreapp3.1
2021-07-01 15:31:54.1484 Trace Assembly 'Microsoft.Extensions.Logging, Version=3.1.16.0, Culture=neutral, PublicKeyToken=adb9793829ddae60' will be hidden in callsite stacktrace
2021-07-01 15:31:54.1484 Trace Assembly 'Microsoft.Extensions.Logging.Abstractions, Version=3.1.16.0, Culture=neutral, PublicKeyToken=adb9793829ddae60' will be hidden in callsite stacktrace
2021-07-01 15:31:54.1484 Debug Auto loading done
2021-07-01 15:31:54.1484 Info Message Template Auto Format enabled
2021-07-01 15:31:54.2142 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.2142 Trace Scanning LongDateLayoutRenderer 'Layout Renderer: ${longdate}'
2021-07-01 15:31:54.4179 Debug Setting 'NLog.LayoutRenderers.Wrappers.UppercaseLayoutRendererWrapper.uppercase' to 'true'
2021-07-01 15:31:54.4179 Trace Wrapping NLog.LayoutRenderers.LevelLayoutRenderer with NLog.LayoutRenderers.Wrappers.UppercaseLayoutRendererWrapper
2021-07-01 15:31:54.4179 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4179 Trace Scanning LevelLayoutRenderer 'Layout Renderer: ${level}'
2021-07-01 15:31:54.4179 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4265 Trace Scanning UppercaseLayoutRendererWrapper 'Layout Renderer: ${uppercase}'
2021-07-01 15:31:54.4265 Trace  Scanning Property Inner 'SimpleLayout=Layout Renderer: ${level}' NLog.Layouts
2021-07-01 15:31:54.4265 Trace  Scanning SimpleLayout 'SimpleLayout=Layout Renderer: ${level}'
2021-07-01 15:31:54.4265 Trace   Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.4265 Trace   Scanning LevelLayoutRenderer 'Layout Renderer: ${level}'
2021-07-01 15:31:54.4265 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4265 Trace Scanning LoggerNameLayoutRenderer 'Layout Renderer: ${logger}'
2021-07-01 15:31:54.4265 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4265 Trace Scanning MessageLayoutRenderer 'Layout Renderer: ${message}'
2021-07-01 15:31:54.4500 Debug Setting 'NLog.Targets.FileTarget.name' to 'logfile'
2021-07-01 15:31:54.4500 Debug Setting 'NLog.Targets.FileTarget.fileName' to 'C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\${shortdate}_logfile.txt'
2021-07-01 15:31:54.4500 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4500 Trace Scanning ShortDateLayoutRenderer 'Layout Renderer: ${shortdate}'
2021-07-01 15:31:54.4500 Debug Setting 'NLog.Targets.FileTarget.layout' to '${longdate} ${level:uppercase=true} ${message}'
2021-07-01 15:31:54.4500 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4500 Trace Scanning LongDateLayoutRenderer 'Layout Renderer: ${longdate}'
2021-07-01 15:31:54.4582 Debug Setting 'NLog.LayoutRenderers.Wrappers.UppercaseLayoutRendererWrapper.uppercase' to 'true'
2021-07-01 15:31:54.4582 Trace Wrapping NLog.LayoutRenderers.LevelLayoutRenderer with NLog.LayoutRenderers.Wrappers.UppercaseLayoutRendererWrapper
2021-07-01 15:31:54.4582 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4582 Trace Scanning LevelLayoutRenderer 'Layout Renderer: ${level}'
2021-07-01 15:31:54.4582 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4582 Trace Scanning UppercaseLayoutRendererWrapper 'Layout Renderer: ${uppercase}'
2021-07-01 15:31:54.4582 Trace  Scanning Property Inner 'SimpleLayout=Layout Renderer: ${level}' NLog.Layouts
2021-07-01 15:31:54.4582 Trace  Scanning SimpleLayout 'SimpleLayout=Layout Renderer: ${level}'
2021-07-01 15:31:54.4582 Trace   Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.4582 Trace   Scanning LevelLayoutRenderer 'Layout Renderer: ${level}'
2021-07-01 15:31:54.4582 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.4582 Trace Scanning MessageLayoutRenderer 'Layout Renderer: ${message}'
2021-07-01 15:31:54.4582 Info Adding target FileTarget(Name=logfile)
2021-07-01 15:31:54.4582 Debug Registered target logfile: NLog.Targets.FileTarget
2021-07-01 15:31:54.4582 Trace ParseRulesElement
2021-07-01 15:31:54.5022 Debug Watching path 'C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1' filter 'nlog.config' for changes.
2021-07-01 15:31:54.5049 Debug --- NLog configuration dump ---
2021-07-01 15:31:54.5049 Debug Targets:
2021-07-01 15:31:54.5325 Debug File Target[logfile]
2021-07-01 15:31:54.5325 Debug Rules:
2021-07-01 15:31:54.5392 Debug logNamePattern: (:All) levels: [ Debug Info Warn Error Fatal ] appendTo: [ logfile ]
2021-07-01 15:31:54.5392 Debug --- End of NLog configuration dump ---
2021-07-01 15:31:54.5392 Trace FindReachableObject<System.Object>:
2021-07-01 15:31:54.5392 Trace Scanning LoggingRule 'logNamePattern: (:All) levels: [ Debug Info Warn Error Fatal ] appendTo: [ logfile ]'
2021-07-01 15:31:54.5392 Trace  Scanning Property Targets 'System.Collections.Generic.List`1[NLog.Targets.Target]' System.Collections.Generic
2021-07-01 15:31:54.5392 Trace  Scanning FileTarget 'File Target[logfile]'
2021-07-01 15:31:54.5392 Trace   Scanning Property FileName ''C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\${shortdate}_logfile.txt'' NLog.Layouts
2021-07-01 15:31:54.5392 Trace   Scanning SimpleLayout ''C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\${shortdate}_logfile.txt''
2021-07-01 15:31:54.5521 Trace    Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.5521 Trace    Scanning LiteralLayoutRenderer 'Layout Renderer: ${literal}'
2021-07-01 15:31:54.5521 Trace    Scanning ShortDateLayoutRenderer 'Layout Renderer: ${shortdate}'
2021-07-01 15:31:54.5521 Trace    Scanning LiteralLayoutRenderer 'Layout Renderer: ${literal}'
2021-07-01 15:31:54.5521 Trace   Scanning Property Layout ''${longdate} ${level:uppercase=true} ${message}'' NLog.Layouts
2021-07-01 15:31:54.5521 Trace   Scanning SimpleLayout ''${longdate} ${level:uppercase=true} ${message}''
2021-07-01 15:31:54.5521 Trace    Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.5521 Trace    Scanning LongDateLayoutRenderer 'Layout Renderer: ${longdate}'
2021-07-01 15:31:54.5521 Trace    Scanning LiteralLayoutRenderer 'Layout Renderer: ${literal}'
2021-07-01 15:31:54.5521 Trace    Scanning UppercaseLayoutRendererWrapper 'Layout Renderer: ${uppercase}'
2021-07-01 15:31:54.5521 Trace     Scanning Property Inner 'SimpleLayout=Layout Renderer: ${level}' NLog.Layouts
2021-07-01 15:31:54.5521 Trace     Scanning SimpleLayout 'SimpleLayout=Layout Renderer: ${level}'
2021-07-01 15:31:54.5521 Trace      Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.5521 Trace      Scanning LevelLayoutRenderer 'Layout Renderer: ${level}'
2021-07-01 15:31:54.5521 Trace    Scanning LiteralLayoutRenderer 'Layout Renderer: ${literal}'
2021-07-01 15:31:54.5521 Trace    Scanning MessageLayoutRenderer 'Layout Renderer: ${message}'
2021-07-01 15:31:54.5521 Trace   Scanning Property LineEnding 'Default' NLog.Targets
2021-07-01 15:31:54.5521 Trace  Scanning Property ChildRules 'System.Collections.Generic.List`1[NLog.Config.LoggingRule]' System.Collections.Generic
2021-07-01 15:31:54.5521 Trace  Scanning Property Filters 'System.Collections.Generic.List`1[NLog.Filters.Filter]' System.Collections.Generic
2021-07-01 15:31:54.5695 Info Validating config: TargetNames=logfile, ConfigItems=14, FilePath=C:\Users\Owner\source\repos\SchoolWebApplication1\SchoolWebApplication1/nlog.config
2021-07-01 15:31:54.5695 Debug Unused target checking is started... Rule Count: 1, Target Count: 1
2021-07-01 15:31:54.5839 Debug Unused target checking is completed. Total Rule Count: 1, Total Target Count: 1, Unused Target Count: 0
2021-07-01 15:31:54.5839 Trace Initializing Layout Renderer: ${message}
2021-07-01 15:31:54.5839 Trace Initializing Layout Renderer: ${literal}
2021-07-01 15:31:54.5839 Trace Initializing Layout Renderer: ${level}
2021-07-01 15:31:54.5839 Trace Initializing SimpleLayout=Layout Renderer: ${level}
2021-07-01 15:31:54.5839 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.5839 Trace Scanning SimpleLayout 'SimpleLayout=Layout Renderer: ${level}'
2021-07-01 15:31:54.5839 Trace  Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.5839 Trace  Scanning LevelLayoutRenderer 'Layout Renderer: ${level}'
2021-07-01 15:31:54.6034 Trace Initializing Layout Renderer: ${uppercase}
2021-07-01 15:31:54.6034 Trace Initializing Layout Renderer: ${literal}
2021-07-01 15:31:54.6034 Trace Initializing Layout Renderer: ${longdate}
2021-07-01 15:31:54.6034 Trace Initializing '${longdate} ${level:uppercase=true} ${message}'
2021-07-01 15:31:54.6034 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.6034 Trace Scanning SimpleLayout ''${longdate} ${level:uppercase=true} ${message}''
2021-07-01 15:31:54.6034 Trace  Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.6034 Trace  Scanning LongDateLayoutRenderer 'Layout Renderer: ${longdate}'
2021-07-01 15:31:54.6034 Trace  Scanning LiteralLayoutRenderer 'Layout Renderer: ${literal}'
2021-07-01 15:31:54.6034 Trace  Scanning UppercaseLayoutRendererWrapper 'Layout Renderer: ${uppercase}'
2021-07-01 15:31:54.6034 Trace   Scanning Property Inner 'SimpleLayout=Layout Renderer: ${level}' NLog.Layouts
2021-07-01 15:31:54.6034 Trace   Scanning SimpleLayout 'SimpleLayout=Layout Renderer: ${level}'
2021-07-01 15:31:54.6034 Trace    Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.6136 Trace    Scanning LevelLayoutRenderer 'Layout Renderer: ${level}'
2021-07-01 15:31:54.6136 Trace  Scanning LiteralLayoutRenderer 'Layout Renderer: ${literal}'
2021-07-01 15:31:54.6136 Trace  Scanning MessageLayoutRenderer 'Layout Renderer: ${message}'
2021-07-01 15:31:54.7604 Trace Initializing Layout Renderer: ${literal}
2021-07-01 15:31:54.7604 Trace Initializing Layout Renderer: ${shortdate}
2021-07-01 15:31:54.7604 Trace Initializing Layout Renderer: ${literal}
2021-07-01 15:31:54.7604 Trace Initializing 'C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\${shortdate}_logfile.txt'
2021-07-01 15:31:54.7604 Trace FindReachableObject<NLog.Internal.IRenderable>:
2021-07-01 15:31:54.7604 Trace Scanning SimpleLayout ''C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\${shortdate}_logfile.txt''
2021-07-01 15:31:54.7604 Trace  Scanning Property Renderers 'System.Collections.ObjectModel.ReadOnlyCollection`1[NLog.LayoutRenderers.LayoutRenderer]' System.Collections.ObjectModel
2021-07-01 15:31:54.7604 Trace  Scanning LiteralLayoutRenderer 'Layout Renderer: ${literal}'
2021-07-01 15:31:54.7604 Trace  Scanning ShortDateLayoutRenderer 'Layout Renderer: ${shortdate}'
2021-07-01 15:31:54.7604 Trace  Scanning LiteralLayoutRenderer 'Layout Renderer: ${literal}'
2021-07-01 15:31:54.7604 Trace Initializing File Target[logfile]
2021-07-01 15:31:54.7604 Trace FindReachableObject<NLog.Layouts.Layout>:
2021-07-01 15:31:54.7706 Trace Scanning FileTarget 'File Target[logfile]'
2021-07-01 15:31:54.7706 Trace  Scanning Property FileName ''C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\${shortdate}_logfile.txt'' NLog.Layouts
2021-07-01 15:31:54.7706 Trace  Scanning SimpleLayout ''C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\${shortdate}_logfile.txt''
2021-07-01 15:31:54.7706 Trace  Scanning Property Layout ''${longdate} ${level:uppercase=true} ${message}'' NLog.Layouts
2021-07-01 15:31:54.7706 Trace  Scanning SimpleLayout ''${longdate} ${level:uppercase=true} ${message}''
2021-07-01 15:31:54.7706 Trace  Scanning Property LineEnding 'Default' NLog.Targets
2021-07-01 15:31:54.7706 Trace File Target[logfile] has 2 layouts
2021-07-01 15:31:54.7706 Trace FileTarget(Name=logfile): Using appenderFactory: NLog.Internal.FileAppenders.RetryingMultiProcessFileAppender+Factory
2021-07-01 15:32:33.4685 Debug Targets for LoggerService.LoggerManager by level:
2021-07-01 15:32:33.4685 Debug Trace =>
2021-07-01 15:32:33.4685 Debug Debug => logfile
2021-07-01 15:32:33.4685 Debug Info => logfile
2021-07-01 15:32:33.4685 Debug Warn => logfile
2021-07-01 15:32:33.4685 Debug Error => logfile
2021-07-01 15:32:33.4685 Debug Fatal => logfile
2021-07-01 15:32:33.5723 Debug FileTarget(Name=logfile): Preparing for new file 'C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt'
2021-07-01 15:32:33.7833 Debug Creating file appender: C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt
2021-07-01 15:32:33.7895 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 15:32:34.0533 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 15:32:34.0533 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 15:32:34.0533 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 15:36:24.1505 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 15:36:24.1687 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 15:36:24.2128 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 15:36:24.2128 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:14:26.5548 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:14:26.5548 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:14:26.5960 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:14:26.5960 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:16:24.4009 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:16:24.4117 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:16:24.4117 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:16:24.4117 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:16:30.7555 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:16:30.7555 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:16:30.7555 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 16:16:30.7555 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 17:30:15.5968 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 17:30:15.8927 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 17:30:15.8953 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
2021-07-01 17:30:15.8953 Trace Opening C:\Users\Owner\Source\repos\SchoolWebApplication1\SchoolWebApplication1\Logs\2021-07-01_logfile.txt with allowFileSharedWriting=False
