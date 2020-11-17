<template>
  <div id="app">
    <TopNavigation />
    <router-view />
  </div>
</template>

<script>
import TopNavigation from "@/components/TopNavigation"
export default {
  components: {
    TopNavigation
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
