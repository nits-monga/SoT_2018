using Xunit;

namespace Vehicle.UnitTests
{
    public class MockEngine : IEngine
    {
        public bool Started => throw new System.NotImplementedException(); // TODO Implement this method

        public void Replace()
        {
            // TODO: Implement this method
        }

        public void Start()
        {
            // TODO: Implement this method
        }

        public void Stop()
        {
            // TODO: Implement this method
        }
    }

    public class car
    {
        [Fact]
        public void car_can_start()
        {
            // arrange
            var bigEngine = new BigEngine(); // TODO: Replace this with the above mock
            var subject = new Car(bigEngine);

            // act
            subject.Start();

            // assert
            Assert.True(subject.Engine.Started, "Car hasn't started");
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
