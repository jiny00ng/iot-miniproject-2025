using System;
using System.Collections.Generic;

namespace WpfMrpSimulatorApp.Models;

public partial class Schedule
{
    public int SchIdx { get; set; }

    /// <summary>
    /// 공장코드
    /// </summary>
    public string PlantCode { get; set; } = null!;

    /// <summary>
    /// 공정계획일
    /// </summary>
    public DateOnly SchDate { get; set; }

    /// <summary>
    /// 초
    /// </summary>
    public int LoadTime { get; set; }

    /// <summary>
    /// 계획된 시작 시간
    /// </summary>
    public TimeOnly? SchStartTime { get; set; }

    public TimeOnly? SchEndTime { get; set; }

    /// <summary>
    /// 생산설비 ID
    /// </summary>
    public string? SchFacilityId { get; set; }

    /// <summary>
    /// 계획 목표 수량
    /// </summary>
    public string? SchAmount { get; set; }

    /// <summary>
    /// 작성일
    /// </summary>
    public DateTime? RegDt { get; set; }

    /// <summary>
    /// 수정일
    /// </summary>
    public DateTime? ModDt { get; set; }

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();
}
