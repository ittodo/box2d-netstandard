using System.Runtime.CompilerServices;

namespace Box2D.NetStandard.Dynamics.Joints
{
	public interface IMotorisedJoint
	{
		float MotorSpeed
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		void SetMotorSpeed(float speed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		float GetMotorSpeed();
	}
}