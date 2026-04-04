[繁體中文](./README_zh.md) | [日本語](./README.md)
# 夜市人生 | Nightmarket Life
#### Unity-based Android Mobile Game Project
## 作品概要 | Project Overview
本專案的開發初衷，是希望透過數位遊戲將台灣獨特的「夜市文化」推向世界。<br>
目標是打造出一款能打破地理限制，讓使用者只需透過智慧型手機，就能隨時隨地體驗台灣夜市熱鬧氛圍與趣味小遊戲的作品。
#### 主要特色：
  - **文化體驗**<p>
  忠實呈現了「套圈圈」與「製作地瓜球」等台灣夜市的經典遊戲 
  - **體感操作**<p>
  活用 Android 的加速度感測器，實現了直覺式的物理操作
  - **隨機探索要素**<p>
  遊戲中會隨機出現「街頭藝人」，增加了探索的趣味性與意想不到的驚喜感
  - **搜集要素**<p>
  獲得的獎品可在「收藏圖鑑」中查看詳細資訊
## demo影片 | Demo Video
[Nightmarket Life Demo Vedio](https://youtube.com/shorts/4tiYfDadhkY)
## 開發環境 | Technical Stack
- **遊戲引擎版本**：Unity 2021.3.22f1
- **開發語言**：C#
- **支援平台**：Android
- **四人規模的團隊專案**
  - **個人貢獻**：作為程式設計師，負責開發所有的核心邏輯、感測器連動、UI 系統以及遊戲流程控制。
## 遊戲玩法與流程 | Gameplay Flow
在遊戲開始後，玩家將體驗到以下四個核心互動流程：
- **套圈圈 (Ring Toss)**：<br>
  機制： 活用加速度感測器，讓玩家透過揮動手機的真實動作來投擲圈圈。成功獲得的獎品將即時同步至「收藏圖鑑」系統。
- **壓壓地瓜球 (Sweet Potato Balls)**：<br>
  這是一款「節奏」形式的小遊戲。玩家需配合時機點擊螢幕來操作壓鏟，透過擠壓旋轉中的地瓜球來賺取遊戲幣。
- **收藏圖鑑 (Collection Book)**：<br>
  這是一個可以確認已獲得獎品的模式。點擊獎品後會放大顯示，並能閱讀關於該項目的簡短介紹文案。
- **隨機事件 (Random Events)**：<br>
  主場景中會隨機出現「街頭藝人」。玩家可以選擇是否要給予打賞。
  - **否**：返回主場景
  - **是**：隨機發生兩種狀況
    - 遊戲幣作為打賞費被扣除隨機金額
    - 打賞後作為回禮，可以獲得遊戲奬品。
## 實作亮點 | Technical Implementation & Key Highlights
1. **使用加速度感測器的直覺式操作**<p>
在「套圈圈」關卡中，我活用了智慧型手機的加速度感測器（Input.acceleration）
    - **課題**：在技術上十分難以將感測器的原始數據直接轉換為投擲軌跡。
    - **解決方法**：透過印出log詳細分析實際揮動裝置時的數值，並計算出對應特定動作的數值。<br>
   將此數值分類為「左、中、右」三個判定區間，並播放對應的動畫，藉此提供玩家毫無違和感的投擲體驗。<p>
2. **場景管理與組件化**
  - 為了管理多個遊戲場景，構建了可從外部指定跳轉目標的通用腳本。
  - **Transition的通用化**：將帶有動畫的過場效果（Transition）製作成 Prefab，設計成從任何場景都能輕鬆調用的架構，從而提升了開發效率。
3. **數據持久化**<p>
    使用 PlayerPrefs 管理獲得的獎品與持有金額等遊戲進度，實作了在 Android 裝置內的資料儲存。
4. **團隊開發中的工作流程**<p>
    在開發初期階段製作了詳細的 Storyboard，統一了程式設計師與設計師之間的認知。<br>
    藉此避免出現需要反覆修改 UI 按鈕佈局及畫面遷移邏輯的情況。
<p align="center">
  <img src="/docs/01-storyboard.jpg" width="40%" />
  <img src="/docs/02-storyboard.jpg" width="40%" />
</p>

## 安裝方法
1. 從本儲存庫的 [Releases](https://github.com/chenyi092/Nightmarket_Life/releases/tag/v1.0.0) 頁面下載最新的 .apk 檔案。
2. 將檔案傳輸至 Android 裝置。
3. 請在裝置設定中允許「安裝來自未知來源的應用程式」。
4. 執行 .apk 檔案，並完成安裝。
## demo畫面
<p align="center">
  <img src="/docs/03-home.png" width="20%" />
  <img src="/docs/04-ring.png" width="20%" />
  <img src="/docs/05-rule.png" width="20%" />
  <img src="/docs/06-potato.png" width="20%" />
</p>
<p align="center">
  <img src="/docs/07-press.png" width="20%" />
  <img src="/docs/08-artist.png" width="20%" />
  <img src="/docs/09-collection.png" width="20%" />
  <img src="/docs/10-event.png" width="20%" />
</p>
