﻿namespace AutoGarmin
{
    public static class Const //Constants of the program
    {
        public static class Color 
        {
            public static System.Windows.Media.SolidColorBrush Transparent()
            {
                return new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 255, 255, 255));
            }

            public static System.Windows.Media.SolidColorBrush DeviceStartAuto()
            {
                return new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(11, 89, 141));
            }

            public static System.Windows.Media.SolidColorBrush DeviceReady()
            {
                return new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(71, 156, 14));
            }

            public static System.Windows.Media.SolidColorBrush Warning()
            {
                return new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(174, 188, 18));
            }

            public static System.Windows.Media.SolidColorBrush Error()
            {
                return new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(134, 42, 42));
            }

            public static System.Windows.Media.SolidColorBrush DeviceConnect()
            {
                return new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(104, 33, 122));
            }
        }

        public static class Title //Window title
        {
            public const string Main = "AutoGarmin 1.0";
            public const string MainAutoOn = Main + " - (Авторежим)";
            public const string ChooseFile = "Выбор файла для заливки";
            public const string RenameDevice = "Новое наименование устройства";
        }
        
        public static class Xml //Xml
        {
            public const string Id = "Id"; //id device
            public const string Model = "Model"; //Data
            public const string Description = "Description"; //Model
            public const string Nickname = "Nickname"; //name
        }

        public static class Log //Log messages
        {
            public const string DeviceConnect = "Устройство подключено.";
            public const string DeviceDisconnect = "Устройство отключено.";
            public const string DeviceStartAuto = "Старт авторежима.";
            public const string DeviceEndAuto = "Устройство готово к работе.";
            public const string DeviceTracksDownload = "Скачаны треки.";
            public const string DeviceTracksClean = "Очищена папка с треками.";
            public const string DeviceMapsClean = "Очищена папка с картами.";
            public const string DeviceMapLoad = "Карта залита.";
            public const string DeviceRename = "Изменено наименование на ";
            public const string DeviceNicknameAdd = "Добавлено наименование ";
            public const string DeviceNicknameDelete = "Наименование удалено.";

            public static class Error
            {
                public const string RenameDevice = "Не удалось изменить наименование устройства.";

                public const string DeviceTracksDownload = "Не удалось скачать треки.";
                public const string NoTracksFolder = "На устройстве отсуствует папка треков. Треки не были скачаны.";

                public const string DeviceTracksClean = "Не удалось очистить папку с треками.";
                public const string NoTracksFolderClean = "На устройстве отсуствует папка треков. Папка треков не была очищена.";

                public const string DeviceMapsClean = "Не удалось очистить папку с картами.";
                public const string NoMapsFolder = "На устройстве отсуствует папка карт. Папка карт не была очищена.";

                public const string DeviceMapLoad = "Не удалось залить карту.";
                public const string NoMapFile = "Не выбран файл карты. Карта не была залита.";
            }
        }

        public static class Label //The text for the interface
        {
            public const string NoNickname = "Нет наименования";
            public const string FileSize = "Размер файла";

            public static class ToolTip
            {
                public const string Error = "Ошибка. Подробнее смотрите в логах действий.";
                public const string Warning = "Предупреждение. Подробнее смотрите в логах действий.";
                public const string Ready = "Устройство готово к работе.";
            }

            public static class ButonAuto
            {
                public const string On = "Авторежим";
                public const string Off = "Включить";
            }
        }

        public static class Error //Error message
        {
            public const string NoKmz = "У выбранного файла расширение не .kmz, вы хотите продолжить?";
            public const string WordError = "Ошибка";
            public const string WordWarning = "Предупреждение";
            public const string Copy = "Ошибка при копировании файла карты.";
            public const string LoadMapNotWork = "Заливка карты без файла не работает.";
            public const string NoMapFile = "Нет файла карты.";

            public const string DuplicateApplication = "Программа AutoGarmin уже запущена.";
            public const string DuplicateApplicationTitle = "Ошибка при запуске";

        }

        public static class Path //Work with files
        {
            public const string MapFileExtension = ".kmz";
            public const string CustomMaps = @"CustomMaps";
            public const string CustomMapsPath = @"Garmin\" + CustomMaps;
            public const string GPX = @"GPX";
            public const string GPXPath = @"Garmin\" + GPX;
            public const string GarminXml = @"\Garmin\GarminDevice.xml";
            public const string GarminIco = @"\Garmin\Garmintriangletm.ico";
            public const string NoIco = @"pack://application:,,,/no.ico";
            public const string Icon = @"pack://application:,,,/icon.ico";
            public const string IconAuto = @"pack://application:,,,/icon_auto.ico";

            public static class Sound 
            {
                public const string Connect = @"sounds/connect.wav";
                public const string Ready = @"sounds/ready.wav";
                public const string Error = @"sounds/error.wav";
                public const string Disconnect = @"sounds/disconnect.wav";
            }
        }

        public static class Time //Time format
        {
            public const string Connect = "HH:mm:ss";
            public const string Log = "HH:mm:ss";
            public const string Folder = "HH-mm-ss";
        }
    }
}
