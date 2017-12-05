/*	--------------------------------------------------------------------------------------------------------------------------------------------
 
	Well hello, curious student person.
	This is the JuiceBox, a collection of movements, bumps and wiggles you can add to your GameObjects to make them "juicy".
	
	The JuiceBox is built using a free tweening library called iTween - http://www.pixelplacement.com/itween/index.php
	iTween is included in the JuiceBox files, so you can make use of it at any point. Be experimental!

	iTween is a large and powerful collection, capable of far more than you see here.
	We're (deliberately) not going to do everything for you! Can you add some functions of your own to build a more complete JuiceBox?
	How about a function to make an object spin indefinitely? How about patrolling between 2 points? There's plenty you could do.
	
	-------------------------------------------------------------------------------------------------------------------------------------------- */

using UnityEngine;

public class JuiceBox {
	
	// The PopIn function. Scales an object up from 0 to its normal size. Good for popping an object into the world.
	public static void PopIn(GameObject obj, float time = 1.5f, float delay = 0, iTween.EaseType easeType = iTween.EaseType.easeOutElastic) {
		if (iTween.Count (obj, "scale") < 1) {
			iTween.ScaleFrom(obj, iTween.Hash("scale", Vector3.zero, "time", time, "delay", delay, "easetype", easeType ));
		}
	}

	// The PopOut function. Scales an object down to 0 from its normal size. Good for popping an object out of the world.
	public static void PopOut(GameObject obj, float time = .2f, float delay = 0, iTween.EaseType easeType = iTween.EaseType.easeInQuad) {
		if (iTween.Count (obj, "scale") < 1) {
			iTween.ScaleTo(obj, iTween.Hash("scale", Vector3.zero, "time", time, "delay", delay, "easetype", easeType ));
		}
	}

	// The Rattle function. Causes an object to rotate randomly for a small duration. Good for showing interaction between objects.
	public static void Rattle(GameObject obj, float power = 10, float time = .6f) {
		iTween.ShakeRotation(obj, iTween.Hash("amount", Vector3.one * power, "time", time, "easetype", iTween.EaseType.easeInOutQuad ));
	}

	// The Wobble function. Causes an object to move randomly for a small duration. Good for showing interaction between objects.
	public static void Wobble(GameObject obj, float power = .1f, float time = .4f) {
		iTween.ShakePosition(obj, iTween.Hash("amount", Vector3.one * power, "time", time, "easetype", iTween.EaseType.easeInOutQuad ));
	}

	// The Jiggle function. Causes an object to scale randomly for a small duration. Good for showing interaction between objects.
	public static void Jiggle(GameObject obj, float power = .1f, float time = .4f) {
		iTween.ShakeScale(obj, iTween.Hash("amount", Vector3.one * power, "time", time, "easetype", iTween.EaseType.easeInOutQuad ));
	}

	// The Rock function. Rotates an object back and forth indefinitely. Good for rotating objects back and forth indefinitely ;)
	public static void Rock(GameObject obj, float amount = 10, float time = 1.5f, iTween.EaseType easeType = iTween.EaseType.easeInOutCubic) {
		if (iTween.Count (obj, "rotate") < 1) {
			obj.transform.Rotate (0, 0, -amount);
			iTween.RotateBy (obj, iTween.Hash ("amount", new Vector3 (0, 0, 2 * amount / 360), "time", time, "easetype", easeType, "looptype", "pingPong"));
		}
	}

	/* To do
	Rattle2D
	Wobble2D
	Jiggle2D
	ScreenShake
	ScreenShake2D
	*/
		
}
