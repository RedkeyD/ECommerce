﻿namespace Application.Abstractions
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
