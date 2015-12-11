using System;
using Castle.ActiveRecord;

namespace TonyKit.Domain
{
    public class BaseModel<T>:ActiveRecordBase
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [PrimaryKey]
        public T Id { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [Property]
        public DateTime AddDate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Property]
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        [Property]
        public DateTime? DeleteDate { get; set; }

        /// <summary>
        ///是否启用 
        /// </summary>
        [Property]
        public bool IsEnable { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Property]
        public bool IsDelete { get; set; }
    }
}