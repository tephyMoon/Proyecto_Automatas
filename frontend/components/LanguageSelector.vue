<script setup lang="ts">
/**
 * Selector de idioma (es/en/ru/zh/ar)
 * 🔌 Integración futura:
 *  - Propagar el idioma al endpoint del backend.
 */
const model = defineModel<string>({ required: true })
const options = ['Español', 'Inglés', 'Ruso', 'Chino', 'Árabe']
</script>

<template>
  <div class="p-4 border border-primary rounded-2xl bg-primary/20">
    <label class="block text-sm mb-2">Idioma del texto</label>
    <select v-model="model"
            class="w-full rounded-lg bg-primary/50 border border-primary px-3 py-2">
      <option v-for="opt in options" :key="opt" :value="opt">{{ opt }}</option>
    </select>
  </div>
</template>
