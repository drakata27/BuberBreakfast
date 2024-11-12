using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    void UpsertBreakfast(Breakfast breakfast);
    Breakfast GetBreakfast(Guid id);
    void DeleteBreakfast(Guid id);
    
}