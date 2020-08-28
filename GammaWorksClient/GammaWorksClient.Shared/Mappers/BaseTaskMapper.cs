using GammaWorksClient.Shared.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GammaWorksClient.Shared.Mappers
{
    public class BaseTaskMapper
    {
        public BaseTaskMapper() { }

        public static BaseTaskModel BaseTaskEntityToModel(BaseTaskEntity baseTaskEntity)
        {
            BaseTaskModel baseTaskModel = new BaseTaskModel
            {
                Descr = baseTaskEntity.Descr,
                PlannedStart = new DateTimeOffset(baseTaskEntity.PlannedStart, DateTimeOffset.Now.Offset),
                PlannedFinish = new DateTimeOffset(baseTaskEntity.PlannedFinish, DateTimeOffset.Now.Offset),
                ActualStart = (baseTaskEntity.ActualStart == 0
                                        ? DateTimeOffset.MinValue 
                                        : new DateTimeOffset(baseTaskEntity.ActualStart, DateTimeOffset.Now.Offset)),
                ActualFinish = (baseTaskEntity.ActualFinish == 0
                                    ? DateTimeOffset.MinValue
                                    : new DateTimeOffset(baseTaskEntity.ActualFinish, DateTimeOffset.Now.Offset)),
                Priority = baseTaskEntity.Priority,
                RegNo = baseTaskEntity.RegNo,
                Status = baseTaskEntity.Status,
                Id = baseTaskEntity.Id
            };

            return baseTaskModel;
        }

        public static BaseTaskEntity BaseTaskModelToEntity(BaseTaskModel baseTaskPar)
        {
            BaseTaskEntity baseTaskEntity = new BaseTaskEntity
            {
                Descr = baseTaskPar.Descr,
                PlannedStart = baseTaskPar.PlannedStart.UtcTicks,
                PlannedFinish = baseTaskPar.PlannedFinish.UtcTicks,
                ActualStart = baseTaskPar.ActualStart.UtcTicks,
                ActualFinish = baseTaskPar.ActualFinish.UtcTicks,
                Priority = baseTaskPar.Priority,
                RegNo = baseTaskPar.RegNo,
                Status = baseTaskPar.Status,
                Id = baseTaskPar.Id
            };

            return baseTaskEntity;
        }
    }
}
