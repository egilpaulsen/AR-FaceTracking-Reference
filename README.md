# AR FaceTracking Reference Models
Example meshes and animations that uses the blendshape naming the way ARKit does. The project includes an example scene that runs simple motion captured and manually key framed animations. 

Compatible with Unity 2018.3.

## Instructions for installing AR FaceTracking Reference Models project

1. Download the latest version of Unity 2019.2

2. Open Unity and load the project at the root of the *AR FaceTracking Reference* repository

3. Open HeadReference scene.

4. Create an empty GameObject. Within this GameObject, create an object called Head. 

5. Add to the Head object a SkinnedMeshRenderer component. Add your fbxmesh containing the blendshapes. See already existing examples for reference. 

6. Your blendshapes have to have the same prefix as one of the other meshes in the scene in order to make the animations work. See the HumanReference head for comparison. 

## Preferred blendshape naming

For ease of use, please use the same naming convention as in the ARKitBlendShapeLocation attribute after the last punctuation. For example, **BrowDownLeft**. 
Other names has been used, for example the Sloth-example from unity uses **blendShape2.browDown_L**. This requires a workaround to make captured animation properties have the same name in the hiearchy, which is not easy. 

Therefore, stick with the names used for the HumanReference in the project (See the animations linked in _FaceAnimations Human_-animatorController

```
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowDownLeft]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowDownRight] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowInnerUp]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowOuterUpLeft]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.BrowOuterUpRight]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.CheekPuff]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.CheekSquintLeft] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.CheekSquintRight]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeBlinkLeft]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeBlinkRight]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookDownLeft]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookDownRight]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookInLeft]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookInRight] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookOutLeft] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookOutRight]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookUpLeft]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeLookUpRight] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeSquintLeft]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeSquintRight] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeWideLeft]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.EyeWideRight]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.JawForward]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.JawLeft]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.JawOpen]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.JawRight] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthClose]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthDimpleLeft] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthDimpleRight]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthFrownLeft]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthFrownRight] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthFunnel]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthLeft]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthLowerDownLeft]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthLowerDownRight]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthPressLeft]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthPressRight]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthPucker]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthRight]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthRollLower]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthRollUpper]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthShrugLower]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthShrugUpper]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthSmileLeft] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthSmileRight] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthStretchLeft]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthStretchRight]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthUpperUpLeft] 
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.MouthUpperUpRight]
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.NoseSneerLeft]   
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.NoseSneerRight]  
m_FaceArkitBlendShapeIndexMap[ARKitBlendShapeLocation.TongueOut]  

```
