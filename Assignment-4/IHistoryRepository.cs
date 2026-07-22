using System.Collections.Generic;

interface IHistoryRepository
{
    void Save(
        string calculationDetails);

    IReadOnlyList<string> GetAll();
}