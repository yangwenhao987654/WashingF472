using System;
using AutoTF;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms.Design;
using System.Xml;

namespace DWZ_Scada
{
    public enum BrowasableEnum
    {
        操作员 = 1,
        工程师 = 2,
        管理员 = 3,
    }

    #region 自定义特性

    /// <summary>
    /// 权限管控特性,用来决定不同用户看到不同的属性,必须与Browsable同时出现,因为默认Browsable的值无法修改
    /// </summary>
    class PermissionAttribute : Attribute
    {
        private int lvl;
        public int Lvl
        {

            get { return lvl; }

        }
        public PermissionAttribute(int des)
        {
            this.lvl = des;
        }
    }
    #endregion

    [Serializable]
    public class SystemParams
    {
        //用json格式保存,方便在程序未启动时手动修改配置


        public SystemParams Clone()
        {
            //浅拷贝
            return this.MemberwiseClone() as SystemParams;
        }

        public enum VoiceSpeedLvl
        {
            特慢 = -2,
            慢 = -1,
            一般 = 0,
            快 = 1,
            特快 = 2,
        }

        public enum DBConfigType
        {
            默认,
            生产环境,
            测试环境
        }
        //用json格式保存,方便在程序未启动时手动修改配置
        public enum StationEnum
        {
            OP10上料打码工站,
            OP20机械手绕线工站,
            OP30绕线检查工站,
            OP40TIG电焊工站,
            OP60电测工站,
            OP70出料打码工站,
        }

        public static SystemParams Instance = new SystemParams();
        public static string Path = $@"{AppDomain.CurrentDomain.BaseDirectory}Params\Params.json";
        public static string PathBackup = $@"{AppDomain.CurrentDomain.BaseDirectory}Params\Params-backup.json";

        public static string ParamsBackupDirectory =System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Params","BackUp");

        [field: NonSerialized]
        public event Action RefreshResultEvent;

        /// <summary>
        /// 站别切换事件
        /// </summary>
        [field: NonSerialized]
        public static event Action StationChanged;
        [field: NonSerialized]
        private StationEnum _station;

        [Permission(3), ReadOnly(false)]
        [DisplayName("1.设备厂商"), Category("A.其他配置"), Description("设备厂商名称展示")]
        public string DeviceCompany { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("2.设备名称"), Category("A.其他配置"), Description("设备名称展示")]
        public string DeviceName { get; set; }

        [Permission(3), ReadOnly(true)]
        [DisplayName("A.Logo文件路径"), Category("A.其他配置"), Description("主页公司Logo图片路径")]
        public string LogoFilePath { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("B.公司名称"), Category("A.其他配置"), Description("主页公司名称展示")]
        public string CompanyName { get; set; }

        #region OP10工站参数

        [Permission(3), ReadOnly(false)]
        [DisplayName("1.扫码枪串口名称"), Category("1.通讯配置"), Description("扫码枪的Com口")]
        public string ScannerComName{ get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("2.称重器串口名称"), Category("1.通讯配置"), Description("称重器的Com口")]
        public string WeightComName { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("1.ModbusTCP_IO IP地址"), Category("1.通讯配置"), Description("ModbusIO卡的IP地址")]
        public string ModbusIP { get; set; }
        [Permission(3), ReadOnly(false)]
        [DisplayName("2.ModbusTCP_IO 端口号"), Category("1.通讯配置"), Description("ModbusIO卡的端口号")]
        public int ModbusPort { get; set; }


        [EditorAttribute(typeof(FileNameEditor), typeof(UITypeEditor))]
        [Permission(3), ReadOnly(false)]
        [DisplayName("1.数据库配置"), Category("2.数据库配置"), Description("数据库文件位置")]
        public string DBFilePath { get; set; }
        #endregion

        #region 软件配置参数
        [Permission(3), ReadOnly(false)]
        [DisplayName("1.是否启用语音播报"), Category("A.软件配置"), Description("配置选择是否使用语音提示功能")]
        //[Browsable(false)]
        public bool IsUseVoicePrompt { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("1.语速选择"), Category("A.软件配置"), Description("选择分拣机语音提示的播报速度")]
        //[Browsable(false)]
        public VoiceSpeedLvl VoiceSpeed { get; set; }

        #endregion

        #region 登陆参数

        [Browsable(false)]
        [Newtonsoft.Json.JsonIgnore]
        public string Op { get; set; }

        /// <summary>
        /// OPLvl ==10 表示管理员 1贴签机 2分拣机
        /// </summary>
        [Browsable(false)]
        [JsonIgnore]
        public int OpLvl { get; set; }

        [Browsable(false)]
        [JsonIgnore]
        public string OPRule { get; set; }
        #endregion

        #region 视觉图片参数

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 是否自动保存OK注释图片"), Category("9.视觉图像配置"), Description("配置是否保存视觉OK注释图像")]
        public bool SaveAnnotatedImage { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 是否自动保存NG注释图片"), Category("9.视觉图像配置"), Description("配置是否保存视觉NG注释图像")]
        public bool SaveNGAnnotatedImage { get; set; }


        [DisplayName("9.1 保存视觉注释图片的路径"), Category("9.视觉图像配置"), Description("配置保存视觉注释图片的路径")]
        [Permission(3), ReadOnly(false)]
        public string ImageAnnotatedPath { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 是否自动保存图片"), Category("9.视觉图像配置"), Description("配置是否保存拍照图像")]
        public bool EnableSaveImage { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 是否保存OK图片"), Category("9.视觉图像配置"), Description("配置是否保存拍照OK图像")]
        public bool SaveOKImage { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 是否保存NG图片"), Category("9.视觉图像配置"), Description("配置是否保存拍照NG图像")]
        public bool SaveNGImage { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 保存图片的路径"), Category("9.视觉图像配置"), Description("配置保存图片的路径同时也是清理图片的路径")]
        public string ImagePath { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 是否自动清理图片"), Category("9.视觉图像配置"), Description("配置是否定期自动清理保存备份图像")]
        public bool DeleteEnable { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 图片最大容量 单位(GB)"), Category("9.视觉图像配置"), Description("配置图像保存占用的最大空间，达到设定容量后执行自动清理备份图片")]
        public int DeleteSize { get; set; }

        [Permission(3), ReadOnly(false)]
        [DisplayName("9.1 图片保存时间 单位(天)"), Category("9.视觉图像配置"), Description("配置图像保存时间，达到设定时间后执行自动清理备份图片")]
        public string DeleteTime { get; set; }

        #endregion

        /// <summary>
        /// 用户登录事件
        /// </summary>
        public static event Action OPChangeEvent;

        public void ChangeBrowsable(BrowasableEnum lvl)
        {
            Type permissionType = typeof(PermissionAttribute);
            PropertyDescriptorCollection appSetingAttributes = TypeDescriptor.GetProperties(this);
            FieldInfo fieldInfo = permissionType.GetField("lvl", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance);
            foreach (PropertyDescriptor item in appSetingAttributes)
            {
                //存在特性PermissionAttribute
                var att = item.Attributes[permissionType];
                if (att == null)
                {
                    continue;
                }
                var index = (int)fieldInfo.GetValue(att);
                if (index <= (int)lvl)
                {
                    SetPropertyReadOnly(item, false);
                }
                else
                {
                    SetPropertyReadOnly(item, true);
                }
            }
        }

        public static void SetPropertyReadOnly(PropertyDescriptor p, bool readOnly)
        {
            Type type = typeof(System.ComponentModel.ReadOnlyAttribute);
            FieldInfo fld = type.GetField("isReadOnly", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance);
            fld.SetValue(p.Attributes[type], readOnly);
        }
        private void ChangeBrowsable(PropertyDescriptor p, bool result)
        {
            Type browsableType = typeof(BrowsableAttribute);
            FieldInfo fieldInfo = browsableType.GetField("browsable", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.CreateInstance);
            fieldInfo.SetValue(p.Attributes[browsableType], result);
        }

        /// <summary>
        /// 加载配置参数 Json
        /// </summary>
        /// <returns></returns>
        public static string Load()
        {
            var errMsg = "";
            try
            {
                if (!File.Exists(Path))
                {
                    errMsg = $"加载配置文件失败! [配置文件不存在] [{Path}]";
                    return errMsg;
                }
                using (StreamReader sr = new StreamReader(Path, Encoding.UTF8))
                {
                    var s = sr.ReadToEnd();
                    Instance = JsonConvert.DeserializeObject(s, typeof(SystemParams)) as SystemParams;
                    if (Instance == null)
                    {
                        Instance = new SystemParams();
                        errMsg = "加载配置文件失败! [{反序列化json失败}]";
                        return errMsg;
                    }

                    LoadConfig();
                }
                return errMsg;
            }
            catch (Exception ex)
            {
                errMsg = $"加载配置文件失败! [{ex.Message}]";
                return errMsg;
            }
            finally
            {

            }
        }

        private static void LoadConfig()
        {
            SpeckMessage.IsUseVoicePrompt = Instance.IsUseVoicePrompt;
            SpeckMessage.Rate = (int )Instance.VoiceSpeed;
        }

        public static string Save()
        {
            var errMsg = "";
            try
            {
                var fileInfo = new FileInfo(Path);
                if (fileInfo.Exists)
                {
                    //fileInfo.CopyTo(PathBackup, true);
                    Directory.CreateDirectory(ParamsBackupDirectory);
                    string path = System.IO.Path.Combine(ParamsBackupDirectory,
                        $"{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff-}Params.json");
                    fileInfo.CopyTo(path, true);
                    AutoDeleteBackFile();
                }

                string json = JsonConvert.SerializeObject(Instance, Newtonsoft.Json.Formatting.Indented);//1. 序列化 //2.设置缩进
                fileInfo.Directory.Create();
                using (StreamWriter sw = new StreamWriter(Path, false, Encoding.UTF8))
                {
                    sw.Write(json);
                }
            }
            catch (Exception ex)
            {
                errMsg = $"保存配置文件失败! [{ex.Message}]";
                return errMsg;
            }
            return errMsg;
        }

        private static void AutoDeleteBackFile()
        {
            int maxFiles = 50;
            if (Directory.Exists(ParamsBackupDirectory))
            {
                var files = Directory.GetFiles(ParamsBackupDirectory,"*Params.json")
                    .OrderByDescending(f => f)
                    .ToList();

                if (files.Count > maxFiles)
                {
                    foreach (var file in files.Skip(maxFiles))
                    {
                        try
                        {
                            File.Delete(file);
                            //Console.WriteLine($"Deleted: {file}");
                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine($"Error deleting file {file}: {ex.Message}");
                        }
                    }
                }
                else
                {
                    //Console.WriteLine("The number of files is within the limit.");
                }
            }
            else
            {
                //Console.WriteLine("Directory does not exist.");
            }
        }

        public void Login(string name, int lvl, string rule)
        {
            if (name == Op && lvl == OpLvl && rule == OPRule)
            {
                return;
            }
            Op = name;
            OpLvl = lvl;
            OPRule = rule;
            OPChangeEvent?.Invoke();
        }


        /// <summary>
        /// 使用反射进行深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="original"></param>
        /// <returns></returns>
        static T CreateDeepCopy<T>(T original)
        {
            if (original == null)
            {
                return default(T);
            }

            Type type = original.GetType();
            object newObject = Activator.CreateInstance(type);

            foreach (FieldInfo fieldInfo in type.GetFields())
            {
                if (fieldInfo.IsStatic)
                {
                    continue;
                }

                object value = fieldInfo.GetValue(original);
                fieldInfo.SetValue(newObject, CreateDeepCopy(value));
            }

            return (T)newObject;
        }
    }
}
