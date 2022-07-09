/// <summary>
/// マスのステート
/// 今後列挙型はこのように分けて置きたい
/// </summary>
public enum Status
{
    NonSpace,
    Wall,
    StartPosition,
    GoalPosition,
    Open,
    Close
}