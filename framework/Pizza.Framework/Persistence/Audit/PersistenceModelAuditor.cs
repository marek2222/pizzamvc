﻿using System;
using System.Linq;
using NHibernate.Persister.Entity;
using Pizza.Contracts.Persistence;
using Pizza.Contracts.Presentation.Security;
using Pizza.Framework.Security;
using Pizza.Framework.Utils;

namespace Pizza.Framework.Persistence.Audit
{
    public class PersistenceModelAuditor
    {
        private readonly string createdBy = ObjectHelper.GetPropertyName<IAuditable>(x => x.CreatedBy);
        private readonly string createdTime = ObjectHelper.GetPropertyName<IAuditable>(x => x.CreatedTime);
        private readonly string changedBy = ObjectHelper.GetPropertyName<IAuditable>(x => x.ChangedBy);
        private readonly string changedTime = ObjectHelper.GetPropertyName<IAuditable>(x => x.ChangedTime);

        private readonly IPizzaUserContext _applicationUserContext;

        public PersistenceModelAuditor(IPizzaUserContext applicationUserContext)
        {
            this._applicationUserContext = applicationUserContext;
        }

        public void Insert(IAuditable auditable, object[] state, IEntityPersister persister)
        {
            if (auditable == null)
                return;

            this.SetCreate(auditable, state);
            this.SetChange(auditable, state);
        }

        public void Update(IAuditable auditable, object[] oldState, object[] state, IEntityPersister persister)
        {
            if (auditable == null)
                return;

            this.SetChange(auditable, state);
        }

        private void SetCreate(IAuditable auditable, object[] state)
        {
            auditable.CreatedBy = this.GetUserId();
            auditable.CreatedTime = DateTime.Now;

            this.SetState(state, this.createdBy, auditable.CreatedBy);
            this.SetState(state, this.createdTime, auditable.CreatedTime);
        }

        private void SetChange(IAuditable auditable, object[] state)
        {
            auditable.ChangedBy = this.GetUserId();
            auditable.ChangedTime = DateTime.Now;

            this.SetState(state, this.changedBy, auditable.ChangedBy);
            this.SetState(state, this.changedTime, auditable.ChangedTime);
        }

        private void SetState(object[] state, string propertyName, object value)
        {
            var auditableModel = state.SingleOrDefault(x => x is IAuditable);
            if (auditableModel == null)
                return;

            var property = typeof(IAuditable).GetProperty(propertyName);
            property.SetValue(auditableModel, value, null);
        }

        private int GetUserId()
        {
            return this._applicationUserContext.CurrentUser.Id;
        }
    }
}