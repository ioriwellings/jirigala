﻿//-----------------------------------------------------------------
// All Rights Reserved , Copyright (C) 2012 , Hairihan TECH, Ltd. 
//-----------------------------------------------------------------

using System;
using System.Data;

namespace DotNet.Business
{

    /// <summary>
    ///	BaseManager
    /// 通用基类部分
    /// 
    /// 总觉得自己写的程序不上档次，这些新技术也玩玩，也许做出来的东西更专业了。
    /// 修改纪录
    /// 
    ///		2012.02.04 版本：1.0 JiRiGaLa 进行提炼，把代码进行分组。
    ///
    /// 版本：1.0
    ///
    /// <author>
    ///		<name>JiRiGaLa</name>
    ///		<date>2012.02.04</date>
    /// </author> 
    /// </summary>
    public partial class BaseManager : IBaseManager
    {
        //
        // 树型结构的算法，递归算法
        //

        #region public DataTable GetParentsByCode(string fieldCode, string code, string order) 获取父节点列表
        /// <summary>
        /// 获取父节点列表
        /// </summary>
        /// <param name="fieldCode">编码字段</param>
        /// <param name="code">编码</param>
        /// <param name="order">排序</param>
        /// <returns>数据表</returns>
        public DataTable GetParentsByCode(string fieldCode, string code, string order)
        {
            return DbLogic.GetParentsByCode(DbHelper, this.CurrentTableName, fieldCode, code, order);
        }
        #endregion

        #region public DataTable GetChildrens(string fieldId, string id, string fieldParentId, string order) 获取子节点列表
        /// <summary>
        /// 获取子节点列表
        /// </summary>
        /// <param name="fieldId">主键字段</param>
        /// <param name="id">值</param>
        /// <param name="fieldParentId">父亲节点字段</param>
        /// <param name="order">排序</param>
        /// <returns>数据表</returns>
        public DataTable GetChildrens(string fieldId, string id, string fieldParentId, string order)
        {
            return DbLogic.GetChildrens(DbHelper, this.CurrentTableName, fieldId, id, fieldParentId, order);
        }
        #endregion

        #region public DataTable GetChildrensByCode(string fieldCode, string code, string order) 获取子节点列表
        /// <summary>
        /// 获取子节点列表
        /// </summary>
        /// <param name="fieldCode">编码字段</param>
        /// <param name="code">编码</param>
        /// <param name="order">排序</param>
        /// <returns>数据表</returns>
        public DataTable GetChildrensByCode(string fieldCode, string code, string order)
        {
            return DbLogic.GetChildrensByCode(DbHelper, this.CurrentTableName, fieldCode, code, order);
        }
        #endregion

        #region public DataTable GetParentChildrensByCode(string fieldCode, string code, string order) 获取父子节点列表
        /// <summary>
        /// 获取父子节点列表
        /// </summary>
        /// <param name="fieldCode">编码字段</param>
        /// <param name="code">编码</param>
        /// <param name="order">排序</param>
        /// <returns>数据表</returns>
        public DataTable GetParentChildrensByCode(string fieldCode, string code, string order)
        {
            return DbLogic.GetParentChildrensByCode(DbHelper, this.CurrentTableName, fieldCode, code, order);
        }
        #endregion


        #region public string[] GetParentsIdByCode(string fieldCode, string code) 获取父节点列表
        /// <summary>
        /// 获取父节点列表
        /// </summary>
        /// <param name="fieldCode">编码字段</param>
        /// <param name="code">编码</param>
        /// <returns>主键数组</returns>
        public string[] GetParentsIdByCode(string fieldCode, string code)
        {
            return DbLogic.GetParentsIDByCode(DbHelper, this.CurrentTableName, fieldCode, code, string.Empty);
        }
        #endregion

        #region public string[] GetChildrensId(string fieldId, string id, string fieldParentId) 获取子节点列表
        /// <summary>
        /// 获取子节点列表
        /// </summary>
        /// <param name="fieldId">主键字段</param>
        /// <param name="id">值</param>
        /// <param name="fieldParentId">父亲节点字段</param>
        /// <param name="order">排序</param>
        /// <returns>主键数组</returns>
        public string[] GetChildrensId(string fieldId, string id, string fieldParentId)
        {
            return DbLogic.GetChildrensId(DbHelper, this.CurrentTableName, fieldId, id, fieldParentId, string.Empty);
        }
        #endregion

        #region public string[] GetChildrensByIdCode(string fieldCode, string code) 获取子节点列表
        /// <summary>
        /// 获取子节点列表
        /// </summary>
        /// <param name="fieldCode">编码字段</param>
        /// <param name="code">编码</param>
        /// <returns>主键数组</returns>
        public string[] GetChildrensIdByCode(string fieldCode, string code)
        {
            return DbLogic.GetChildrensIdByCode(DbHelper, this.CurrentTableName, fieldCode, code, string.Empty);
        }
        #endregion

        #region public string[] GetParentChildrensIdByCode(string fieldCode, string code) 获取父子节点列表
        /// <summary>
        /// 获取父子节点列表
        /// </summary>
        /// <param name="fieldCode">编码字段</param>
        /// <param name="code">编码</param>
        /// <returns>主键数组</returns>
        public string[] GetParentChildrensIdByCode(string fieldCode, string code)
        {
            return DbLogic.GetParentChildrensIdByCode(DbHelper, this.CurrentTableName, fieldCode, code, string.Empty);
        }
        #endregion

        #region public string GetParentIdByCode(string fieldCode, string code) 获取父节点
        /// <summary>
        /// 获取父节点
        /// </summary>
        /// <param name="fieldCode">编码字段</param>
        /// <param name="code">编号</param>
        /// <returns>主键</returns>
        public string GetParentIdByCode(string fieldCode, string code)
        {
            return DbLogic.GetParentIdByCode(DbHelper, this.CurrentTableName, fieldCode, code);
        }
        #endregion
    }
}