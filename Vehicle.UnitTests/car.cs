using Moq;
using Xunit;

namespace Vehicle.UnitTests
{
    public class car
    {
        [Fact]
        public void car_can_start()
        {
            // TODO: Use fixture to create the car
            // arrange
            var engineMock = new Mock<IEngine>();
            var subject = new Car(engineMock.Object);

            // act
            subject.Start();

            // assert
            engineMock.Verify(e => e.Start(), Times.Once());

            // TODO: this line will fail, make it pass
            //Assert.True(subject.Engine.Started, "Car hasn't started");

            // TODO: Update all unit tests to use a mock
        }

        [Fact]
        public void car_can_stop()
        {
            // TODO: arrange
            // TODO: act
            // TODO: assert
        }

        [Fact]
        public void car_cannot_move_forward_if_not_started()
        {
            // TODO: arrange
            // TODO: act
            // TODO: assert
        }

        [Theory]
        [InlineData(4, 4)]
        // TODO: More data to be added
        public void car_can_move_forward_and_consumes_petrol(int timesToMoveForward, int expectedPetrolLitresConsumed)
        {
            // arrange
            var bigEngine = new BigEngine();  // TODO: Replace this with the above mock
            var subject = new Car(bigEngine);
            subject.Start();

            // act
            while (timesToMoveForward > 0)
            {
                subject.MoveForward();
                timesToMoveForward--;
            }

            // assert
            Assert.Equal(expectedPetrolLitresConsumed, subject.PetrolLitresConsumed);
        }
    }
}
