﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;
using Legal.LawSearch.Services;
using Legal.LawSearch.ViewModels;
using Legal.LawSearch.Conditions;

namespace Legal.LawContentSearch
{
    public class LawContentSearch
    {
        //public List<LawContentVM> GetLawContents(LawSearchCondition condition, LawContentService service)
        //{
        //    if (condition == null) { return null; }

        //    if (condition.StartDate.HasValue && condition.EndDate.HasValue)
        //    {
        //        if (((DateTime)condition.EndDate - (DateTime)condition.StartDate).TotalDays > 366)
        //        {
        //            return null;
        //        }
        //    }

        //    var lawContents = service.GetLawContents(condition);
        //    var totalRecords = lawContents.Count == 0 ? 0 : lawContents[0].TotalRecords;
        //    return lawContents;
        //}
    }
}
