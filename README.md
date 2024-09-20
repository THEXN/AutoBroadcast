# 本仓库已不再更新，已经整合到：https://github.com/UnrealMultiple/TShockPlugin，后续更新均会发布至此仓库
# This repository is no longer updated and has been integrated into: https://github.com/UnrealMultiple/TShockPlugin. All future updates will be published there.
# 自动广播
简介
---
可以通过各种方式向玩家广播预定义的消息，例如基于时间的间隔或通过聊天中的某些词或进入某个区域作为触发器。

作者
---
原Zaicon,GK 小改良，肝帝熙恩汉化更新

配置
---
_AutoBroadcastConfig.json_

| 选项 | 类型 | 默认值 |
|---|---|---|
| 广播列表 | Broadcast[] | |

_Broadcast_

| 选项 | 类型 | 描述 |
|---|---|---|
| 名称 | string | |
| 是否启用 | boolean | |
| 消息列表 | string[] | |
| 颜色RGB | float[] | |
| 间隔时间 | int | 时间驱动广播的间隔（秒）。 |
| 延迟时间 | int | 发送第一个广播前的延迟时间（秒）。 |
| 触发区域 | string[] | 当玩家进入时，将触发广播的区域列表。 |
| 区域触发器 | string | "none": 向所有玩家广播<br />"region": 向当前区域内的玩家广播<br />"self": 只向触发广播的玩家广播。 |
| 组 | string[] | 显示广播的组列表，或可以触发广播的组。使用 `*` 表示所有组。 |
| 触发词 | string[] | 将触发广播的词列表。 |
| 触发整个组 | boolean | |

## 支持与反馈

如果您在使用过程中遇到问题或有任何建议，欢迎在官方论坛或社区中提出 issues。

- GitHub 仓库：https://github.com/THEXN/AutoBroadcast
