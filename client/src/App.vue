<template>
  <div id="app">
    <TopNavigation />
    <main class="container mt-5">
      <router-view />
    </main>
  </div>
</template>

<script>
import TopNavigation from "@/components/TopNavigation"
export default {
  components: {
    TopNavigation
  },
  mounted() {
    this.getQuestions
  }
}
</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

</style>
