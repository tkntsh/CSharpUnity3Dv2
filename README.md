# TouchScript

The `touchScript` is a Unity C# script designed to handle touch input for rotating a GameObject based on user gestures. This script demonstrates basic interaction with Unity's `Input` system, allowing rotation of objects when the user moves their finger across the screen.

---

## Features

### 1. **Touch Detection**
- Detects single-touch gestures.
- Responds to the movement of touch (`TouchPhase.Moved`).

### 2. **Object Rotation**
- Rotates the GameObject around the Z-axis based on touch movement.
- The rotation speed can be adjusted using the `rotationmodify` parameter.

---

## Key Functionalities

### Touch-Based Rotation
- Utilizes `Input.GetTouch(0)` to track the first touch.
- Dynamically adjusts the GameObject's rotation based on the touch's delta position.

### Adjustable Parameters
- **Rotation Speed**: Modify the `rotationmodify` value to increase or decrease sensitivity to touch movements.

---

## Setup Instructions

1. Attach the `touchScript` to the GameObject you want to rotate.
2. Customize the following parameters in the Unity Editor as needed:
   - `rotationmodify`: Adjust the sensitivity of touch-based rotation.
3. Ensure the GameObject has a Transform component for rotation.

---

## Key Classes and Methods

- **Update()**: 
  - Monitors the touch count on the screen.
  - Responds to `TouchPhase.Moved` to apply rotation to the GameObject.

---

## Skills Demonstrated
- Unity touch input handling with `Input.touchCount` and `Touch` API.
- Real-time object manipulation through rotation using `Quaternion`.
- Smooth gesture-based interaction mechanics for mobile platforms.

---

## Notes
- This script currently supports only single-touch input. For multi-touch or advanced gestures, additional logic can be implemented.

---

## License
This script is open-source and available for educational and non-commercial use. Attribution is appreciated.
