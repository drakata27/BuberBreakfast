namespace BuberBreakfast.Contracts.Breakfast;

public record BreakfastResponse(
    Guid Id,
    string Name, 
    string Description, 
    DateTime StartDate, 
    DateTime EndDate,
    DateTime LastModifiedDateTime, 
    List<string> Savory,
    List<string> Sweet);