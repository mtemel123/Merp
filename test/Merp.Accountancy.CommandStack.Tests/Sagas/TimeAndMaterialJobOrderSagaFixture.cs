﻿using Memento.Persistence;
using Merp.Accountancy.CommandStack.Sagas;
using Moq;
using NUnit.Framework;
using Rebus.Bus;
using SharpTestsEx;
using System;

namespace Merp.Accountancy.CommandStack.Tests.Sagas
{
    [TestFixture]
    public class TimeAndMaterialJobOrderSagaFixture
    {
        //[Test]
        //public void Ctor_should_throw_ArgumentNullException_on_null_jobOrderNumberGenerator()
        //{
        //    var bus = new Mock<IBus>().Object;
        //    var eventStore = new Mock<IEventStore>().Object;
        //    var repository = new Mock<IRepository>().Object;

        //    Executing.This(() => new TimeAndMaterialJobOrderSaga(bus, eventStore, repository, null))
        //        .Should()
        //        .Throw<ArgumentNullException>()
        //        .And
        //        .ValueOf
        //        .ParamName
        //        .Should()
        //        .Be
        //        .EqualTo("jobOrderNumberGenerator");
        //}
    }
}
