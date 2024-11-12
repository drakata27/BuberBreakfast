namespace BuberBreakfast.Contracts.Breakfast;

public record UpsertRequest(
    Guid Id,
    string Name, 
    string Description, 
    DateTime StartDate, 
    DateTime EndDate,
    DateTime LastModifiedDateTime, 
    List<string> Savory,
    List<string> Sweet);