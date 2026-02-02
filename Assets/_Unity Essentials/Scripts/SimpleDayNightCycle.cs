using UnityEngine;

public class SimpleDayNightCycle : MonoBehaviour
{
    [Header("Time Settings")]
    [Tooltip("游戏中完整的一天（24小时）对应的现实世界秒数")]
    [SerializeField] private float dayDurationInSeconds = 120f; // 默认2分钟为一天

    [Header("Axis Settings")]
    [Tooltip("太阳绕哪个轴旋转？通常是 X 轴 (1, 0, 0)")]
    [SerializeField] private Vector3 rotationAxis = Vector3.right;

    private void Update()
    {
        // 最佳实践：总是进行简单的防御性编程，防止除以零错误
        if (dayDurationInSeconds <= 0) return;

        // 计算每秒需要旋转的角度
        // 公式：360度 / 一天的总秒数
        float rotationSpeed = 360f / dayDurationInSeconds;

        // 执行旋转
        // 使用 Time.deltaTime 确保运动平滑且独立于帧率
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}