using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace VisionNet472.DAL.Entity
{
    [SugarTable("tbOpUser")]
    public class OpUser
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] // 主键，自增列
        public int Id { get; set; }

        public string UserName { get; set; }

        [SugarColumn(IsNullable = true)] // 允许为空
        public string Password { get; set; }

        public string UserCode { get; set; }

        /// <summary>
        /// 用户类型
        /// 管理员，普通用户
        /// </summary>
        ///
        [SugarColumn(DefaultValue ="0")]  // 设置默认值
        public int UserType { get; set; }
    }
}
