# Pavlov-C#
<style>
    .doom-container {
  background-color: #1a1a1a;
  color: #ff4d4d;
  padding: 25px;
  border-radius: 10px;
  border: 3px solid #ff4d4d;
  font-family: 'Courier New', monospace;
  box-shadow: 0 0 15px rgba(255, 77, 77, 0.5);
}

.doom-title {
  text-align: center;
  font-size: 2.8em;
  margin-bottom: 25px;
  text-shadow: 3px 3px 6px #000000;
  animation: flicker 1.5s infinite alternate;
}

.doom-text {
  font-size: 1.2em;
  line-height: 1.6;
  margin-bottom: 20px;
  text-shadow: 1px 1px 2px #000000;
}

.doom-list {
  list-style-type: none;
  padding-left: 0;
}

.doom-list li {
  font-size: 1.1em;
  margin-bottom: 12px;
  padding-left: 25px;
  position: relative;
}

.doom-list li::before {
  content: '🖤';
  position: absolute;
  left: 0;
  filter: drop-shadow(1px 1px 2px #ff4d4d);
}

.doom-footer {
  text-align: center;
  margin-top: 25px;
  font-size: 1.4em;
  font-weight: bold;
  animation: pulse 2s infinite;
}

@keyframes flicker {
  0% {
    opacity: 1;
  }
  50% {
    opacity: 0.7;
  }
  100% {
    opacity: 1;
  }
}

@keyframes pulse {
  0% {
    transform: scale(1);
  }
  50% {
    transform: scale(1.05);
  }
  100% {
    transform: scale(1);
  }
}
</style>
<div class="doom-container">
        <h1 class="doom-title">🖤 Добро пожаловать в ад 🖤</h1>
        <p class="doom-text">
          Этот репозиторий — собрание практических работ по C#, которые прошли через огонь, серу и бесконечные часы отладки. 
          Здесь вы найдете:
        </p>
        <ul class="doom-list">
          <li>💀 Код, который не компилируется с первого, второго и даже третьего раза.</li>
          <li>🔥 Бесконечные циклы, которые заставят ваш процессор плакать.</li>
          <li>🕳️ Магические числа, которые никто не сможет объяснить.</li>
          <li>😱 Исключения, которые возникают просто потому, что им так захотелось.</li>
          <li>⚰️ Документацию, написанную кровью и слезами.</li>
        </ul>
        <p class="doom-text">
          Если вы решили продолжить, знайте: <strong>ваша душа уже принадлежит этому репозиторию</strong>.
        </p>
        <div class="doom-footer">
          <p>🚨 Сбежать можно, но зачем? 🚨</p>
        </div>
      </div>
